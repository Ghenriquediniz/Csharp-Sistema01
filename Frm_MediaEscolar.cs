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
    public partial class Frm_MediaEscolar : Form
    {
        public Frm_MediaEscolar()
        {
            InitializeComponent();
        }

        private void MédiaEscolar_Load(object sender, EventArgs e)
        {
        }

        private void lblMedia_Click(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            float nota1, nota2, nota3, nota4, media;
            bool verifica;
            string status;

            verifica = float.TryParse(txtNota1.Text, out nota1);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valore inválido na nota1");
                return;
            }
            verifica = float.TryParse(txtNota2.Text, out nota2);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valore inválido na nota2");
                return;
            }
            verifica = float.TryParse(txtNota3.Text, out nota3);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valore inválido na nota3");
                return;
            }
            verifica = float.TryParse(txtNota4.Text, out nota4);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valore inválido na nota4");
                return;
            }

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 5)
            {
                status = "Aluno aprovado!";
            }
            else if (media >= 4 && media < 5)
            {
                status = "Aluno de recuperação";
            }
            else
            {
                status = "Aluno reprovado";
            }


            lblMedia.Text = string.Format("Média: {0} - Aluno: {1}", media, status);
        }
    }
}
