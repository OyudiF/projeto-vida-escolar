using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vida_escolar
{
    public partial class FormCadastroEscola : Form
    {
        public string CodEOL => txtCodEOL.Text.Trim();
        public string INEP => txtINEP.Text.Trim();
        public string TipoUnidade => cbTipoUnidade.SelectedItem?.ToString() ?? "";
        public string NomeEscola => txtNomeEscola.Text.Trim();
        public string Fone => txtFone.Text.Trim();
        public string Email => txtEmail.Text.Trim();
        public FormCadastroEscola()
        {
            InitializeComponent();
            cbTipoUnidade.Items.AddRange(new string[]
            {
                "CECI", "CEI DIRET", "CEI INDIR", "CEU AT COMPL", "CEU CEI", "CEU CEMEI", "CEU EMEF", "CEU EMEI", "CEU POLO", "CIEJA", "CR.P.CONV", "EMEBS", "EMEF", "EMEFM", "EMEI", "ESC.PART."
            });

            cbTipoUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoUnidade.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CodEOL) ||
                string.IsNullOrWhiteSpace(INEP) ||
                string.IsNullOrWhiteSpace(TipoUnidade) ||
                string.IsNullOrWhiteSpace(NomeEscola))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios (CodEOL, INEP, TipoUnidade, NomeEscola).");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
