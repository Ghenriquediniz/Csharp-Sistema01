namespace Aula_02
{
    partial class Frm_ValidaCPF
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
            this.mskcpftext = new System.Windows.Forms.MaskedTextBox();
            this.btnlimpa = new System.Windows.Forms.Button();
            this.btnvalida = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskcpftext
            // 
            this.mskcpftext.Location = new System.Drawing.Point(12, 47);
            this.mskcpftext.Mask = "000,000,000-00";
            this.mskcpftext.Name = "mskcpftext";
            this.mskcpftext.Size = new System.Drawing.Size(185, 20);
            this.mskcpftext.TabIndex = 0;
            // 
            // btnlimpa
            // 
            this.btnlimpa.Location = new System.Drawing.Point(212, 31);
            this.btnlimpa.Name = "btnlimpa";
            this.btnlimpa.Size = new System.Drawing.Size(110, 23);
            this.btnlimpa.TabIndex = 1;
            this.btnlimpa.Text = "Limpa";
            this.btnlimpa.UseVisualStyleBackColor = true;
            this.btnlimpa.Click += new System.EventHandler(this.btnlimpa_Click);
            // 
            // btnvalida
            // 
            this.btnvalida.Location = new System.Drawing.Point(212, 60);
            this.btnvalida.Name = "btnvalida";
            this.btnvalida.Size = new System.Drawing.Size(110, 23);
            this.btnvalida.TabIndex = 2;
            this.btnvalida.Text = "Valida";
            this.btnvalida.UseVisualStyleBackColor = true;
            this.btnvalida.Click += new System.EventHandler(this.btnvalida_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(12, 85);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(24, 20);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "...";
            // 
            // Frm_ValidaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 126);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnvalida);
            this.Controls.Add(this.btnlimpa);
            this.Controls.Add(this.mskcpftext);
            this.Name = "Frm_ValidaCPF";
            this.Text = "CPF";
            this.Load += new System.EventHandler(this.Frm_ValidaCPF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskcpftext;
        private System.Windows.Forms.Button btnlimpa;
        private System.Windows.Forms.Button btnvalida;
        private System.Windows.Forms.Label lblresultado;
    }
}