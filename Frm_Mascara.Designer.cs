namespace Aula_02
{
    partial class Data
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
            this.btnhora = new System.Windows.Forms.Button();
            this.btnsenha = new System.Windows.Forms.Button();
            this.btndata = new System.Windows.Forms.Button();
            this.btnmoeda = new System.Windows.Forms.Button();
            this.btncep = new System.Windows.Forms.Button();
            this.btntelefone = new System.Windows.Forms.Button();
            this.btnconteudo = new System.Windows.Forms.Button();
            this.msktext = new System.Windows.Forms.MaskedTextBox();
            this.lblexibir = new System.Windows.Forms.Label();
            this.lblersultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhora
            // 
            this.btnhora.Location = new System.Drawing.Point(52, 129);
            this.btnhora.Name = "btnhora";
            this.btnhora.Size = new System.Drawing.Size(86, 37);
            this.btnhora.TabIndex = 0;
            this.btnhora.Text = "Hora";
            this.btnhora.UseVisualStyleBackColor = true;
            this.btnhora.Click += new System.EventHandler(this.btnhora_Click);
            // 
            // btnsenha
            // 
            this.btnsenha.Location = new System.Drawing.Point(144, 176);
            this.btnsenha.Name = "btnsenha";
            this.btnsenha.Size = new System.Drawing.Size(91, 37);
            this.btnsenha.TabIndex = 1;
            this.btnsenha.Text = "Senha";
            this.btnsenha.UseVisualStyleBackColor = true;
            this.btnsenha.Click += new System.EventHandler(this.btnsenha_Click);
            // 
            // btndata
            // 
            this.btndata.Location = new System.Drawing.Point(53, 176);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(85, 37);
            this.btndata.TabIndex = 2;
            this.btndata.Text = "Data";
            this.btndata.UseVisualStyleBackColor = true;
            this.btndata.Click += new System.EventHandler(this.btndata_Click);
            // 
            // btnmoeda
            // 
            this.btnmoeda.Location = new System.Drawing.Point(241, 129);
            this.btnmoeda.Name = "btnmoeda";
            this.btnmoeda.Size = new System.Drawing.Size(91, 37);
            this.btnmoeda.TabIndex = 3;
            this.btnmoeda.Text = "Moeda";
            this.btnmoeda.UseVisualStyleBackColor = true;
            this.btnmoeda.Click += new System.EventHandler(this.btnmoeda_Click);
            // 
            // btncep
            // 
            this.btncep.Location = new System.Drawing.Point(144, 129);
            this.btncep.Name = "btncep";
            this.btncep.Size = new System.Drawing.Size(91, 37);
            this.btncep.TabIndex = 4;
            this.btncep.Text = "CEP";
            this.btncep.UseVisualStyleBackColor = true;
            this.btncep.Click += new System.EventHandler(this.btncep_Click);
            // 
            // btntelefone
            // 
            this.btntelefone.Location = new System.Drawing.Point(241, 176);
            this.btntelefone.Name = "btntelefone";
            this.btntelefone.Size = new System.Drawing.Size(91, 37);
            this.btntelefone.TabIndex = 6;
            this.btntelefone.Text = "Telefone";
            this.btntelefone.UseVisualStyleBackColor = true;
            this.btntelefone.Click += new System.EventHandler(this.btntelefone_Click);
            // 
            // btnconteudo
            // 
            this.btnconteudo.Location = new System.Drawing.Point(53, 219);
            this.btnconteudo.Name = "btnconteudo";
            this.btnconteudo.Size = new System.Drawing.Size(279, 32);
            this.btnconteudo.TabIndex = 7;
            this.btnconteudo.Text = "Ver Conteúdo";
            this.btnconteudo.UseVisualStyleBackColor = true;
            this.btnconteudo.Click += new System.EventHandler(this.btnconteudo_Click);
            // 
            // msktext
            // 
            this.msktext.Location = new System.Drawing.Point(52, 52);
            this.msktext.Name = "msktext";
            this.msktext.Size = new System.Drawing.Size(280, 20);
            this.msktext.TabIndex = 11;
            this.msktext.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktext_MaskInputRejected);
            // 
            // lblexibir
            // 
            this.lblexibir.AutoSize = true;
            this.lblexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexibir.Location = new System.Drawing.Point(49, 88);
            this.lblexibir.Name = "lblexibir";
            this.lblexibir.Size = new System.Drawing.Size(28, 24);
            this.lblexibir.TabIndex = 12;
            this.lblexibir.Text = "...";
            // 
            // lblersultado
            // 
            this.lblersultado.AutoSize = true;
            this.lblersultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblersultado.Location = new System.Drawing.Point(49, 254);
            this.lblersultado.Name = "lblersultado";
            this.lblersultado.Size = new System.Drawing.Size(28, 24);
            this.lblersultado.TabIndex = 13;
            this.lblersultado.Text = "...";
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 305);
            this.Controls.Add(this.lblersultado);
            this.Controls.Add(this.lblexibir);
            this.Controls.Add(this.msktext);
            this.Controls.Add(this.btnconteudo);
            this.Controls.Add(this.btntelefone);
            this.Controls.Add(this.btncep);
            this.Controls.Add(this.btnmoeda);
            this.Controls.Add(this.btndata);
            this.Controls.Add(this.btnsenha);
            this.Controls.Add(this.btnhora);
            this.Name = "Data";
            this.Text = "Mascaras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhora;
        private System.Windows.Forms.Button btnsenha;
        private System.Windows.Forms.Button btndata;
        private System.Windows.Forms.Button btnmoeda;
        private System.Windows.Forms.Button btncep;
        private System.Windows.Forms.Button btntelefone;
        private System.Windows.Forms.Button btnconteudo;
        private System.Windows.Forms.MaskedTextBox msktext;
        private System.Windows.Forms.Label lblexibir;
        private System.Windows.Forms.Label lblersultado;
    }
}

