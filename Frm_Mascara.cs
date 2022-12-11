using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntelefone_Click(object sender, EventArgs e)
        {
            msktext.UseSystemPasswordChar = false;
            lblersultado.Text = "";
            msktext.Mask = "(00) 00000-0000";
            lblexibir.Text = msktext.Mask;
            msktext.Text = "";
            msktext.Focus(); //Foco do cursor
        }

        private void txtindo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhora_Click(object sender, EventArgs e)
        {
            lblersultado.Text = "";
            msktext.Mask = "00:00";
            lblexibir.Text = msktext.Mask;
            msktext.Text = "";
            msktext.Focus(); //Foco do cursor
        }

        private void msktext_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnconteudo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(msktext.Text, "Mensagem de Resultado", MessageBoxButtons.OK);
        }

        private void btncep_Click(object sender, EventArgs e)
        {
            msktext.UseSystemPasswordChar = false;
            lblersultado.Text = "";
            msktext.Mask = "00000-000";
            lblexibir.Text = msktext.Mask;
            msktext.Text = "";
            msktext.Focus(); //Foco do cursor
        }

        private void btnmoeda_Click(object sender, EventArgs e)
        {
            msktext.UseSystemPasswordChar = false;
            lblersultado.Text = "";
            msktext.Mask = "$ 000,000,000.00";
            lblexibir.Text = msktext.Mask;
            msktext.Text = "";
            msktext.Focus(); //Foco do cursor
        }

        private void btndata_Click(object sender, EventArgs e)
        {
            msktext.UseSystemPasswordChar = false;
            lblersultado.Text = "";
            msktext.Mask = "00/00/0000";
            lblexibir.Text = msktext.Mask;
            msktext.Text = "";
            msktext.Focus(); //Foco do cursor
        }

        private void btnsenha_Click(object sender, EventArgs e)
        {
            msktext.UseSystemPasswordChar = true;
            lblersultado.Text = "";
            msktext.Mask = "000000";
            lblexibir.Text = msktext.Mask;
            msktext.Text = "";
            msktext.Focus(); //Foco do cursor
        }
    }
}
