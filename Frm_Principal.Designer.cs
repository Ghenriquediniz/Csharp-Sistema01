namespace Aula_02
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.btncpf = new System.Windows.Forms.Button();
            this.btnmascara = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnmedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncpf
            // 
            this.btncpf.Location = new System.Drawing.Point(12, 46);
            this.btncpf.Name = "btncpf";
            this.btncpf.Size = new System.Drawing.Size(127, 49);
            this.btncpf.TabIndex = 0;
            this.btncpf.Text = "Valída CPF";
            this.btncpf.UseVisualStyleBackColor = true;
            this.btncpf.Click += new System.EventHandler(this.btncpf_Click);
            // 
            // btnmascara
            // 
            this.btnmascara.Location = new System.Drawing.Point(145, 46);
            this.btnmascara.Name = "btnmascara";
            this.btnmascara.Size = new System.Drawing.Size(127, 49);
            this.btnmascara.TabIndex = 1;
            this.btnmascara.Text = "Modelos de Mascaras";
            this.btnmascara.UseVisualStyleBackColor = true;
            this.btnmascara.Click += new System.EventHandler(this.btnmascara_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(12, 101);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(127, 49);
            this.btnsair.TabIndex = 3;
            this.btnsair.Text = "Fechar Sistema";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnmedia
            // 
            this.btnmedia.Location = new System.Drawing.Point(278, 46);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(127, 49);
            this.btnmedia.TabIndex = 2;
            this.btnmedia.Text = "Média Escolar";
            this.btnmedia.UseVisualStyleBackColor = true;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bem vindo ao meu primeiro sistema no C#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(427, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmedia);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnmascara);
            this.Controls.Add(this.btncpf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncpf;
        private System.Windows.Forms.Button btnmascara;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Label label1;
    }
}