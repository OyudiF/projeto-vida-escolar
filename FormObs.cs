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
    public partial class FormObs : Form
    {
        public string Observacao { get; private set; }

        public FormObs(string textoAtual = "")
        {
            InitializeComponent();
            rtxtObs.Text = textoAtual;
        }

        private void btn_SalvarObs_Click(object sender, EventArgs e)
        {
            Observacao = rtxtObs.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
