using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using iTextSharp.text;
using iTextSharp.text.pdf;

/*
 *  Fazer:
 *      - Adicionar Salvamento de PDF - Concluido
 *      - Adicionar Opção de Edição de planilha - Concluído
 *      - Adicionar função de cadastro de escolas em geral (outro formulário) -  Concluído
 *      - Arrumar o o botão de salvar planilha, ao invés de ter que escolher uma escola, ele salvar em geral - Concluído
 *      - Adicionar botão filtro (CheckBox), para listar tudo da planilha - Concluído
 *      - Arrumar o link do Teams - Concluído
 *      -------------------------------------------------------------------------------------
 *      - Adicionar opção de exportar para Excel Migração 
 */

namespace vida_escolar
{
    public partial class VidaEscolar : Form
    {
        private DataTable planilhaCompleta = new DataTable();
        private string caminhoArquivoExcel;
        public VidaEscolar()
        {
            InitializeComponent();
            rbCECI.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCEIDiret.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCEIIndir.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCEUAtCompl.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCEUCei.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCEUCemei.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCEUEmef.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCEUEmei.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCEUPolo.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCieja.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbCRPConv.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbEmebs.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbEmef.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbEmefm.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbEmei.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbESCPart.CheckedChanged += rbTipoUnidade_CheckedChanged;
            rbTodos.CheckedChanged += rbTipoUnidade_CheckedChanged;


            chkBolsa.CheckedChanged += chkBolsaFamilia_CheckedChanged;
        }

        private void btn_CarPla_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xlsm;*.xls|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        caminhoArquivoExcel = ofd.FileName;

                        using (var stream = File.OpenRead(ofd.FileName))
                        using (var package = new OfficeOpenXml.ExcelPackage(stream))
                        {
                            var worksheet = package.Workbook.Worksheets[0];
                            planilhaCompleta = new DataTable();

                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                                planilhaCompleta.Columns.Add(worksheet.Cells[1, col].Text);

                            for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                            {
                                var linha = planilhaCompleta.NewRow();
                                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                                    linha[col - 1] = worksheet.Cells[row, col].Text;
                                planilhaCompleta.Rows.Add(linha);
                            }

                            var escolas = planilhaCompleta.AsEnumerable()
                                .Select(r => r.Field<string>("NomeEscolaCompleto"))
                                .Where(n => !string.IsNullOrEmpty(n))
                                .Distinct()
                                .OrderBy(n => n)
                                .ToList();

                            cb_Unidades.Items.Clear();
                            cb_Unidades.Items.AddRange(escolas.ToArray());

                            dataGridView1.DataSource = null;

                            MessageBox.Show("Planilha carregada com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar a planilha: {ex.Message}");
                    }
                }
            }
        }

        private void cb_Unidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Unidades.SelectedItem == null) return;

            string escolaSelecionada = cb_Unidades.SelectedItem.ToString();

            var dadosFiltrados = planilhaCompleta.AsEnumerable()
                .Where(r => r.Field<string>("NomeEscolaCompleto") == escolaSelecionada);

            if (dadosFiltrados.Any())
            {
                dataGridView1.DataSource = dadosFiltrados.CopyToDataTable();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);

                if (dataGridView1.Columns.Contains("NomeEscolaCompleto"))
                {
                    dataGridView1.Columns["NomeEscolaCompleto"].Visible = false;
                }

                if (dataGridView1.Columns.Contains("Bolsa"))
                {
                    dataGridView1.Columns["Bolsa"].Visible = false;
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Nenhum dado encontrado para a escola selecionada.");
            }
        }

        private void btn_SalvarTeams_Click(object sender, EventArgs e)
        {
            string url = "https://smeprefeituraspgov.sharepoint.com/:f:/s/EquipeNTIC/EmeUqbwKWa1Noaazsj_NY8EBKXL8v3zqJJpvFcMPX6mmuQ?e=2rqIdF";
            try
            {
                MessageBox.Show("Solte o arquivo na pasta do teams!");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o Teams: {ex.Message}");
            }
        }

        private void btn_SalvarPDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Nenhum dado disponível para salvar em PDF.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.FileName = "VidaEscolar.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                        using (Document doc = new Document())
                        using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                        {
                            doc.Open();

                            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                            iTextSharp.text.Font fontCabecalho = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                            iTextSharp.text.Font fontDados = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                            table.WidthPercentage = 100;

                            // Cabeçalhos
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontCabecalho));
                                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                table.AddCell(cell);
                            }

                            // Dados
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow) // Evita linha vazia no final
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        table.AddCell(new Phrase(cell.Value?.ToString() ?? string.Empty, fontDados));
                                    }
                                }
                            }
                            doc.Add(table);
                            doc.Close();
                        }
                        MessageBox.Show("PDF salvo com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar PDF: {ex.Message}");
                    }
                }
            }
        }

        private void btn_SalvarExcel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoArquivoExcel))
            {
                MessageBox.Show("Nenhuma planilha carregada.");
                return;
            }

            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado disponível para salvar.");
                return;
            }

            try
            {
                FileInfo arquivo = new FileInfo(caminhoArquivoExcel);
                using (ExcelPackage package = new ExcelPackage(arquivo))
                {
                    ExcelWorksheet ws = package.Workbook.Worksheets[0];
                    int totalCols = ws.Dimension.End.Column;
                    int totalRows = ws.Dimension.End.Row;

                    // Mapear colunas
                    Dictionary<string, int> colunasMapeadas = new Dictionary<string, int>();
                    for (int col = 1; col <= totalCols; col++)
                    {
                        string nomeColuna = ws.Cells[1, col].Text;
                        if (!string.IsNullOrEmpty(nomeColuna))
                            colunasMapeadas[nomeColuna] = col;
                    }

                    // Encontra a coluna NomeEscolaCompleto
                    if (!colunasMapeadas.TryGetValue("NomeEscolaCompleto", out int colEscola))
                    {
                        MessageBox.Show("Coluna 'NomeEscolaCompleto' não encontrada.");
                        return;
                    }

                    // Atualizar planilha com base no conteúdo do DataGridView
                    foreach (DataGridViewRow linhaGrid in dataGridView1.Rows)
                    {
                        if (linhaGrid.IsNewRow) continue;

                        string nomeEscola = linhaGrid.Cells["NomeEscolaCompleto"]?.Value?.ToString();
                        if (string.IsNullOrEmpty(nomeEscola)) continue;

                        for (int row = 2; row <= totalRows; row++)
                        {
                            if (ws.Cells[row, colEscola].Text == nomeEscola)
                            {
                                foreach (DataGridViewCell cell in linhaGrid.Cells)
                                {
                                    string nomeColuna = dataGridView1.Columns[cell.ColumnIndex].HeaderText;

                                    if (colunasMapeadas.TryGetValue(nomeColuna, out int colExcel))
                                    {
                                        ws.Cells[row, colExcel].Value = cell.Value?.ToString();
                                    }
                                }
                                break; // passa para próxima linha do DataGridView
                            }
                        }
                    }

                    package.Save();
                }

                MessageBox.Show("Alterações salvas na planilha com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var coluna = dataGridView1.Columns[e.ColumnIndex];
            if (coluna.HeaderText == "Obs")
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string valorAtual = row.Cells["Obs"].Value?.ToString() ?? "";

                using (FormObs form = new FormObs(valorAtual))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string novaObs = form.Observacao;
                        row.Cells["Obs"].Value = novaObs;
                    }
                }
            }
        }

        private void btnCadastrarEscola_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoArquivoExcel) || !File.Exists(caminhoArquivoExcel))
            {
                MessageBox.Show("Você precisa carregar uma planilha antes de cadastrar uma escola.");
                return;
            }

            using (var cadastro = new FormCadastroEscola())
            {
                if (cadastro.ShowDialog() == DialogResult.OK)
                {
                    // Lógica de adicionar a nova escola na planilha carregada
                    string nomeCompleto = cadastro.TipoUnidade + " " + cadastro.NomeEscola;

                    try
                    {
                        FileInfo arquivo = new FileInfo(caminhoArquivoExcel);
                        using (var package = new ExcelPackage(arquivo))
                        {
                            var ws = package.Workbook.Worksheets[0];
                            int novaLinha = ws.Dimension.End.Row + 1;

                            ws.Cells[novaLinha, 1].Value = cadastro.CodEOL;
                            ws.Cells[novaLinha, 2].Value = cadastro.INEP;
                            ws.Cells[novaLinha, 3].Value = cadastro.TipoUnidade;
                            ws.Cells[novaLinha, 4].Value = cadastro.NomeEscola;
                            ws.Cells[novaLinha, 5].Value = cadastro.Fone;
                            ws.Cells[novaLinha, 6].Value = cadastro.Email;
                            ws.Cells[novaLinha, 7].Value = nomeCompleto; // NomeEscolaCompleto
                            ws.Cells[novaLinha, 8].Value = ""; // Obs vazia

                            package.Save();
                        }

                        MessageBox.Show("Escola cadastrada com sucesso!");
                        btn_CarPla_Click(null, null); // recarrega os dados da planilha
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar a escola: {ex.Message}");
                    }
                }
            }
        }
    
        private void AplicarFiltros()
        {
            if (planilhaCompleta == null || planilhaCompleta.Rows.Count == 0)
                return;

            string tipoSelecionado = ObterTipoUnidadeSelecionado();
            bool filtrarBolsa = chkBolsa.Checked;

            var dadosFiltrados = planilhaCompleta.AsEnumerable()
                .Where(r =>
                    (string.IsNullOrEmpty(tipoSelecionado) || (r.Field<string>("TipoUnidade")?.Trim() == tipoSelecionado)) &&
                    (!filtrarBolsa || r.Field<string>("Bolsa") == "SIM")
                );

            if (dadosFiltrados.Any())
            {
                dataGridView1.DataSource = dadosFiltrados.CopyToDataTable();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Nenhum dado encontrado com os filtros selecionados.");
            }

            if (dataGridView1.Columns.Contains("NomeEscolaCompleto"))
            {
                dataGridView1.Columns["NomeEscolaCompleto"].Visible = false;
            }

            if (dataGridView1.Columns.Contains("Bolsa"))
            {
                dataGridView1.Columns["Bolsa"].Visible = false;
            }
        }
        private string ObterTipoUnidadeSelecionado()
        {
            foreach (var control in grpTipoUnidade.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    if (rb.Name == "rbTodos")
                        return ""; 
                    return rb.Text.Trim(); 
                }
            }

            if (dataGridView1.Columns.Contains("NomeEscolaCompleto"))
            {
                dataGridView1.Columns["NomeEscolaCompleto"].Visible = false;
            }

            if (dataGridView1.Columns.Contains("Bolsa"))
            {
                dataGridView1.Columns["Bolsa"].Visible = false;
            }

            return "";
        }
        private void chkBolsaFamilia_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
        // RadioButton para selecionar o tipo de unidade
        private void rbTipoUnidade_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}
