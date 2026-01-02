namespace vida_escolar
{
    partial class FormObs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtObs = new System.Windows.Forms.RichTextBox();
            this.btn_SalvarObs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observações";
            // 
            // rtxtObs
            // 
            this.rtxtObs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtObs.Location = new System.Drawing.Point(17, 62);
            this.rtxtObs.Name = "rtxtObs";
            this.rtxtObs.Size = new System.Drawing.Size(612, 427);
            this.rtxtObs.TabIndex = 2;
            this.rtxtObs.Text = "";
            // 
            // btn_SalvarObs
            // 
            this.btn_SalvarObs.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarObs.Location = new System.Drawing.Point(478, 12);
            this.btn_SalvarObs.Name = "btn_SalvarObs";
            this.btn_SalvarObs.Size = new System.Drawing.Size(151, 44);
            this.btn_SalvarObs.TabIndex = 3;
            this.btn_SalvarObs.Text = "Salvar";
            this.btn_SalvarObs.UseVisualStyleBackColor = true;
            this.btn_SalvarObs.Click += new System.EventHandler(this.btn_SalvarObs_Click);
            // 
            // FormObs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 502);
            this.Controls.Add(this.btn_SalvarObs);
            this.Controls.Add(this.rtxtObs);
            this.Controls.Add(this.label1);
            this.Name = "FormObs";
            this.Text = "FormObs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtObs;
        private System.Windows.Forms.Button btn_SalvarObs;
    }
}