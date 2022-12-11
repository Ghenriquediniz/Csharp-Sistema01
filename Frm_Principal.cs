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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btncpf_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF f = new Frm_ValidaCPF();
            f.ShowDialog();
        }

        private void btnmascara_Click(object sender, EventArgs e)
        {
            Data f = new Data();
            f.ShowDialog();
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            Frm_MediaEscolar f = new Frm_MediaEscolar();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
