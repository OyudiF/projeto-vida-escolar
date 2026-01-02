namespace vida_escolar
{
    partial class VidaEscolar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_CarPla = new System.Windows.Forms.Button();
            this.btn_SalvarPDF = new System.Windows.Forms.Button();
            this.btn_SalvarTeams = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_Unidades = new System.Windows.Forms.ComboBox();
            this.btn_SalvarExcel = new System.Windows.Forms.Button();
            this.btnCadastrarEscola = new System.Windows.Forms.Button();
            this.chkBolsa = new System.Windows.Forms.CheckBox();
            this.grpTipoUnidade = new System.Windows.Forms.GroupBox();
            this.rbCEUAtCompl = new System.Windows.Forms.RadioButton();
            this.rbCEUCei = new System.Windows.Forms.RadioButton();
            this.rbCieja = new System.Windows.Forms.RadioButton();
            this.rbEmefm = new System.Windows.Forms.RadioButton();
            this.rbESCPart = new System.Windows.Forms.RadioButton();
            this.rbEmei = new System.Windows.Forms.RadioButton();
            this.rbEmef = new System.Windows.Forms.RadioButton();
            this.rbEmebs = new System.Windows.Forms.RadioButton();
            this.rbCRPConv = new System.Windows.Forms.RadioButton();
            this.rbCEUPolo = new System.Windows.Forms.RadioButton();
            this.rbCEUEmef = new System.Windows.Forms.RadioButton();
            this.rbCEUEmei = new System.Windows.Forms.RadioButton();
            this.rbCEUCemei = new System.Windows.Forms.RadioButton();
            this.rbCEIIndir = new System.Windows.Forms.RadioButton();
            this.rbCEIDiret = new System.Windows.Forms.RadioButton();
            this.rbCECI = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpTipoUnidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CarPla
            // 
            this.btn_CarPla.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CarPla.Location = new System.Drawing.Point(12, 12);
            this.btn_CarPla.Name = "btn_CarPla";
            this.btn_CarPla.Size = new System.Drawing.Size(183, 49);
            this.btn_CarPla.TabIndex = 0;
            this.btn_CarPla.Text = "Carregar Planilha";
            this.btn_CarPla.UseVisualStyleBackColor = true;
            this.btn_CarPla.Click += new System.EventHandler(this.btn_CarPla_Click);
            // 
            // btn_SalvarPDF
            // 
            this.btn_SalvarPDF.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarPDF.Location = new System.Drawing.Point(1382, 12);
            this.btn_SalvarPDF.Name = "btn_SalvarPDF";
            this.btn_SalvarPDF.Size = new System.Drawing.Size(120, 49);
            this.btn_SalvarPDF.TabIndex = 0;
            this.btn_SalvarPDF.Text = "Salvar PDF";
            this.btn_SalvarPDF.UseVisualStyleBackColor = true;
            this.btn_SalvarPDF.Click += new System.EventHandler(this.btn_SalvarPDF_Click);
            // 
            // btn_SalvarTeams
            // 
            this.btn_SalvarTeams.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarTeams.Location = new System.Drawing.Point(1237, 12);
            this.btn_SalvarTeams.Name = "btn_SalvarTeams";
            this.btn_SalvarTeams.Size = new System.Drawing.Size(129, 49);
            this.btn_SalvarTeams.TabIndex = 0;
            this.btn_SalvarTeams.Text = "Abrir Teams";
            this.btn_SalvarTeams.UseVisualStyleBackColor = true;
            this.btn_SalvarTeams.Click += new System.EventHandler(this.btn_SalvarTeams_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1490, 536);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cb_Unidades
            // 
            this.cb_Unidades.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Unidades.FormattingEnabled = true;
            this.cb_Unidades.Location = new System.Drawing.Point(201, 20);
            this.cb_Unidades.Name = "cb_Unidades";
            this.cb_Unidades.Size = new System.Drawing.Size(721, 32);
            this.cb_Unidades.TabIndex = 2;
            this.cb_Unidades.SelectedIndexChanged += new System.EventHandler(this.cb_Unidades_SelectedIndexChanged);
            // 
            // btn_SalvarExcel
            // 
            this.btn_SalvarExcel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarExcel.Location = new System.Drawing.Point(1082, 12);
            this.btn_SalvarExcel.Name = "btn_SalvarExcel";
            this.btn_SalvarExcel.Size = new System.Drawing.Size(137, 49);
            this.btn_SalvarExcel.TabIndex = 0;
            this.btn_SalvarExcel.Text = "Salvar Dados";
            this.btn_SalvarExcel.UseVisualStyleBackColor = true;
            this.btn_SalvarExcel.Click += new System.EventHandler(this.btn_SalvarExcel_Click);
            // 
            // btnCadastrarEscola
            // 
            this.btnCadastrarEscola.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEscola.Location = new System.Drawing.Point(928, 12);
            this.btnCadastrarEscola.Name = "btnCadastrarEscola";
            this.btnCadastrarEscola.Size = new System.Drawing.Size(137, 49);
            this.btnCadastrarEscola.TabIndex = 0;
            this.btnCadastrarEscola.Text = "Cadastrar Unidade";
            this.btnCadastrarEscola.UseVisualStyleBackColor = true;
            this.btnCadastrarEscola.Click += new System.EventHandler(this.btnCadastrarEscola_Click);
            // 
            // chkBolsa
            // 
            this.chkBolsa.AutoSize = true;
            this.chkBolsa.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBolsa.Location = new System.Drawing.Point(969, 88);
            this.chkBolsa.Name = "chkBolsa";
            this.chkBolsa.Size = new System.Drawing.Size(79, 26);
            this.chkBolsa.TabIndex = 3;
            this.chkBolsa.Text = "Bolsa";
            this.chkBolsa.UseVisualStyleBackColor = true;
            // 
            // grpTipoUnidade
            // 
            this.grpTipoUnidade.Controls.Add(this.rbTodos);
            this.grpTipoUnidade.Controls.Add(this.rbCEUAtCompl);
            this.grpTipoUnidade.Controls.Add(this.rbCEUCei);
            this.grpTipoUnidade.Controls.Add(this.rbCieja);
            this.grpTipoUnidade.Controls.Add(this.rbEmefm);
            this.grpTipoUnidade.Controls.Add(this.rbESCPart);
            this.grpTipoUnidade.Controls.Add(this.rbEmei);
            this.grpTipoUnidade.Controls.Add(this.rbEmef);
            this.grpTipoUnidade.Controls.Add(this.rbEmebs);
            this.grpTipoUnidade.Controls.Add(this.rbCRPConv);
            this.grpTipoUnidade.Controls.Add(this.rbCEUPolo);
            this.grpTipoUnidade.Controls.Add(this.rbCEUEmef);
            this.grpTipoUnidade.Controls.Add(this.rbCEUEmei);
            this.grpTipoUnidade.Controls.Add(this.rbCEUCemei);
            this.grpTipoUnidade.Controls.Add(this.rbCEIIndir);
            this.grpTipoUnidade.Controls.Add(this.rbCEIDiret);
            this.grpTipoUnidade.Controls.Add(this.rbCECI);
            this.grpTipoUnidade.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoUnidade.Location = new System.Drawing.Point(13, 67);
            this.grpTipoUnidade.Name = "grpTipoUnidade";
            this.grpTipoUnidade.Size = new System.Drawing.Size(937, 62);
            this.grpTipoUnidade.TabIndex = 4;
            this.grpTipoUnidade.TabStop = false;
            this.grpTipoUnidade.Text = "Tipos de Unidade";
            // 
            // rbCEUAtCompl
            // 
            this.rbCEUAtCompl.AutoSize = true;
            this.rbCEUAtCompl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEUAtCompl.Location = new System.Drawing.Point(100, 38);
            this.rbCEUAtCompl.Name = "rbCEUAtCompl";
            this.rbCEUAtCompl.Size = new System.Drawing.Size(109, 18);
            this.rbCEUAtCompl.TabIndex = 0;
            this.rbCEUAtCompl.TabStop = true;
            this.rbCEUAtCompl.Text = "CEU AT COMPL";
            this.rbCEUAtCompl.UseVisualStyleBackColor = true;
            // 
            // rbCEUCei
            // 
            this.rbCEUCei.AutoSize = true;
            this.rbCEUCei.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEUCei.Location = new System.Drawing.Point(215, 14);
            this.rbCEUCei.Name = "rbCEUCei";
            this.rbCEUCei.Size = new System.Drawing.Size(74, 18);
            this.rbCEUCei.TabIndex = 0;
            this.rbCEUCei.TabStop = true;
            this.rbCEUCei.Text = "CEU CEI";
            this.rbCEUCei.UseVisualStyleBackColor = true;
            // 
            // rbCieja
            // 
            this.rbCieja.AutoSize = true;
            this.rbCieja.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCieja.Location = new System.Drawing.Point(396, 38);
            this.rbCieja.Name = "rbCieja";
            this.rbCieja.Size = new System.Drawing.Size(60, 18);
            this.rbCieja.TabIndex = 0;
            this.rbCieja.TabStop = true;
            this.rbCieja.Text = "CIEJA";
            this.rbCieja.UseVisualStyleBackColor = true;
            // 
            // rbEmefm
            // 
            this.rbEmefm.AutoSize = true;
            this.rbEmefm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmefm.Location = new System.Drawing.Point(577, 38);
            this.rbEmefm.Name = "rbEmefm";
            this.rbEmefm.Size = new System.Drawing.Size(60, 18);
            this.rbEmefm.TabIndex = 0;
            this.rbEmefm.TabStop = true;
            this.rbEmefm.Text = "EMEFM";
            this.rbEmefm.UseVisualStyleBackColor = true;
            // 
            // rbESCPart
            // 
            this.rbESCPart.AutoSize = true;
            this.rbESCPart.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbESCPart.Location = new System.Drawing.Point(643, 14);
            this.rbESCPart.Name = "rbESCPart";
            this.rbESCPart.Size = new System.Drawing.Size(88, 18);
            this.rbESCPart.TabIndex = 0;
            this.rbESCPart.TabStop = true;
            this.rbESCPart.Text = "ESC.PART.";
            this.rbESCPart.UseVisualStyleBackColor = true;
            // 
            // rbEmei
            // 
            this.rbEmei.AutoSize = true;
            this.rbEmei.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmei.Location = new System.Drawing.Point(643, 38);
            this.rbEmei.Name = "rbEmei";
            this.rbEmei.Size = new System.Drawing.Size(53, 18);
            this.rbEmei.TabIndex = 0;
            this.rbEmei.TabStop = true;
            this.rbEmei.Text = "EMEI";
            this.rbEmei.UseVisualStyleBackColor = true;
            // 
            // rbEmef
            // 
            this.rbEmef.AutoSize = true;
            this.rbEmef.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmef.Location = new System.Drawing.Point(577, 14);
            this.rbEmef.Name = "rbEmef";
            this.rbEmef.Size = new System.Drawing.Size(53, 18);
            this.rbEmef.TabIndex = 0;
            this.rbEmef.TabStop = true;
            this.rbEmef.Text = "EMEF";
            this.rbEmef.UseVisualStyleBackColor = true;
            // 
            // rbEmebs
            // 
            this.rbEmebs.AutoSize = true;
            this.rbEmebs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmebs.Location = new System.Drawing.Point(483, 38);
            this.rbEmebs.Name = "rbEmebs";
            this.rbEmebs.Size = new System.Drawing.Size(60, 18);
            this.rbEmebs.TabIndex = 0;
            this.rbEmebs.TabStop = true;
            this.rbEmebs.Text = "EMEBS";
            this.rbEmebs.UseVisualStyleBackColor = true;
            // 
            // rbCRPConv
            // 
            this.rbCRPConv.AutoSize = true;
            this.rbCRPConv.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCRPConv.Location = new System.Drawing.Point(483, 14);
            this.rbCRPConv.Name = "rbCRPConv";
            this.rbCRPConv.Size = new System.Drawing.Size(88, 18);
            this.rbCRPConv.TabIndex = 0;
            this.rbCRPConv.TabStop = true;
            this.rbCRPConv.Text = "CR.P.CONV";
            this.rbCRPConv.UseVisualStyleBackColor = true;
            // 
            // rbCEUPolo
            // 
            this.rbCEUPolo.AutoSize = true;
            this.rbCEUPolo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEUPolo.Location = new System.Drawing.Point(396, 14);
            this.rbCEUPolo.Name = "rbCEUPolo";
            this.rbCEUPolo.Size = new System.Drawing.Size(81, 18);
            this.rbCEUPolo.TabIndex = 0;
            this.rbCEUPolo.TabStop = true;
            this.rbCEUPolo.Text = "CEU POLO";
            this.rbCEUPolo.UseVisualStyleBackColor = true;
            // 
            // rbCEUEmef
            // 
            this.rbCEUEmef.AutoSize = true;
            this.rbCEUEmef.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEUEmef.Location = new System.Drawing.Point(309, 14);
            this.rbCEUEmef.Name = "rbCEUEmef";
            this.rbCEUEmef.Size = new System.Drawing.Size(81, 18);
            this.rbCEUEmef.TabIndex = 0;
            this.rbCEUEmef.TabStop = true;
            this.rbCEUEmef.Text = "CEU EMEF";
            this.rbCEUEmef.UseVisualStyleBackColor = true;
            // 
            // rbCEUEmei
            // 
            this.rbCEUEmei.AutoSize = true;
            this.rbCEUEmei.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEUEmei.Location = new System.Drawing.Point(309, 38);
            this.rbCEUEmei.Name = "rbCEUEmei";
            this.rbCEUEmei.Size = new System.Drawing.Size(81, 18);
            this.rbCEUEmei.TabIndex = 0;
            this.rbCEUEmei.TabStop = true;
            this.rbCEUEmei.Text = "CEU EMEI";
            this.rbCEUEmei.UseVisualStyleBackColor = true;
            // 
            // rbCEUCemei
            // 
            this.rbCEUCemei.AutoSize = true;
            this.rbCEUCemei.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEUCemei.Location = new System.Drawing.Point(215, 38);
            this.rbCEUCemei.Name = "rbCEUCemei";
            this.rbCEUCemei.Size = new System.Drawing.Size(88, 18);
            this.rbCEUCemei.TabIndex = 0;
            this.rbCEUCemei.TabStop = true;
            this.rbCEUCemei.Text = "CEU CEMEI";
            this.rbCEUCemei.UseVisualStyleBackColor = true;
            // 
            // rbCEIIndir
            // 
            this.rbCEIIndir.AutoSize = true;
            this.rbCEIIndir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEIIndir.Location = new System.Drawing.Point(100, 17);
            this.rbCEIIndir.Name = "rbCEIIndir";
            this.rbCEIIndir.Size = new System.Drawing.Size(88, 18);
            this.rbCEIIndir.TabIndex = 0;
            this.rbCEIIndir.TabStop = true;
            this.rbCEIIndir.Text = "CEI INDIR";
            this.rbCEIIndir.UseVisualStyleBackColor = true;
            // 
            // rbCEIDiret
            // 
            this.rbCEIDiret.AutoSize = true;
            this.rbCEIDiret.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCEIDiret.Location = new System.Drawing.Point(6, 38);
            this.rbCEIDiret.Name = "rbCEIDiret";
            this.rbCEIDiret.Size = new System.Drawing.Size(88, 18);
            this.rbCEIDiret.TabIndex = 0;
            this.rbCEIDiret.TabStop = true;
            this.rbCEIDiret.Text = "CEI DIRET";
            this.rbCEIDiret.UseVisualStyleBackColor = true;
            // 
            // rbCECI
            // 
            this.rbCECI.AutoSize = true;
            this.rbCECI.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCECI.Location = new System.Drawing.Point(7, 17);
            this.rbCECI.Name = "rbCECI";
            this.rbCECI.Size = new System.Drawing.Size(53, 18);
            this.rbCECI.TabIndex = 0;
            this.rbCECI.TabStop = true;
            this.rbCECI.Text = "CECI";
            this.rbCECI.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(737, 14);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(193, 18);
            this.rbTodos.TabIndex = 1;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Listar todas as Unidades";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // VidaEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 683);
            this.Controls.Add(this.grpTipoUnidade);
            this.Controls.Add(this.chkBolsa);
            this.Controls.Add(this.cb_Unidades);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrarEscola);
            this.Controls.Add(this.btn_SalvarExcel);
            this.Controls.Add(this.btn_SalvarTeams);
            this.Controls.Add(this.btn_SalvarPDF);
            this.Controls.Add(this.btn_CarPla);
            this.Name = "VidaEscolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VidaEscolar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpTipoUnidade.ResumeLayout(false);
            this.grpTipoUnidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CarPla;
        private System.Windows.Forms.Button btn_SalvarPDF;
        private System.Windows.Forms.Button btn_SalvarTeams;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_Unidades;
        private System.Windows.Forms.Button btn_SalvarExcel;
        private System.Windows.Forms.Button btnCadastrarEscola;
        private System.Windows.Forms.CheckBox chkBolsa;
        private System.Windows.Forms.GroupBox grpTipoUnidade;
        private System.Windows.Forms.RadioButton rbCECI;
        private System.Windows.Forms.RadioButton rbCEUAtCompl;
        private System.Windows.Forms.RadioButton rbCEUCei;
        private System.Windows.Forms.RadioButton rbCieja;
        private System.Windows.Forms.RadioButton rbEmefm;
        private System.Windows.Forms.RadioButton rbESCPart;
        private System.Windows.Forms.RadioButton rbEmei;
        private System.Windows.Forms.RadioButton rbEmef;
        private System.Windows.Forms.RadioButton rbEmebs;
        private System.Windows.Forms.RadioButton rbCRPConv;
        private System.Windows.Forms.RadioButton rbCEUPolo;
        private System.Windows.Forms.RadioButton rbCEUEmef;
        private System.Windows.Forms.RadioButton rbCEUEmei;
        private System.Windows.Forms.RadioButton rbCEUCemei;
        private System.Windows.Forms.RadioButton rbCEIIndir;
        private System.Windows.Forms.RadioButton rbCEIDiret;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}

