namespace Exercicio1_forms
{
    partial class frmExercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNome = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.listaNomes = new System.Windows.Forms.TextBox();
            this.adicionaListaNomes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNome
            // 
            this.addNome.AutoSize = true;
            this.addNome.Location = new System.Drawing.Point(13, 10);
            this.addNome.Name = "addNome";
            this.addNome.Size = new System.Drawing.Size(45, 15);
            this.addNome.TabIndex = 0;
            this.addNome.Text = "NOME:";
            this.addNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nome.Location = new System.Drawing.Point(64, 7);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(239, 23);
            this.nome.TabIndex = 1;
            // 
            // listaNomes
            // 
            this.listaNomes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listaNomes.Location = new System.Drawing.Point(63, 102);
            this.listaNomes.Multiline = true;
            this.listaNomes.Name = "listaNomes";
            this.listaNomes.Size = new System.Drawing.Size(240, 289);
            this.listaNomes.TabIndex = 2;
            // 
            // adicionaListaNomes
            // 
            this.adicionaListaNomes.Location = new System.Drawing.Point(64, 36);
            this.adicionaListaNomes.Name = "adicionaListaNomes";
            this.adicionaListaNomes.Size = new System.Drawing.Size(110, 23);
            this.adicionaListaNomes.TabIndex = 3;
            this.adicionaListaNomes.Text = "Adicionar";
            this.adicionaListaNomes.UseVisualStyleBackColor = true;
            this.adicionaListaNomes.Click += new System.EventHandler(this.btnAdicionaNome);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 461);
            this.Controls.Add(this.adicionaListaNomes);
            this.Controls.Add(this.listaNomes);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.addNome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmExercicio1";
            this.Text = "EXERCICIO 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label addNome;
        private TextBox nome;
        private TextBox listaNomes;
        private Button adicionaListaNomes;
    }
}