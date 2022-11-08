namespace Exercicio_Jogador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nomesJogadores = new System.Windows.Forms.TextBox();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.button_Adiciona = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saída de dados com E-Mail:";
            // 
            // textBox_nomesJogadores
            // 
            this.textBox_nomesJogadores.Location = new System.Drawing.Point(103, 24);
            this.textBox_nomesJogadores.Name = "textBox_nomesJogadores";
            this.textBox_nomesJogadores.Size = new System.Drawing.Size(216, 23);
            this.textBox_nomesJogadores.TabIndex = 2;
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.Enabled = false;
            this.textBox_listaNomes.Location = new System.Drawing.Point(492, 56);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaNomes.Size = new System.Drawing.Size(233, 298);
            this.textBox_listaNomes.TabIndex = 3;
            // 
            // button_Adiciona
            // 
            this.button_Adiciona.AutoEllipsis = true;
            this.button_Adiciona.Location = new System.Drawing.Point(103, 57);
            this.button_Adiciona.Name = "button_Adiciona";
            this.button_Adiciona.Size = new System.Drawing.Size(75, 23);
            this.button_Adiciona.TabIndex = 4;
            this.button_Adiciona.Text = "Adicionar";
            this.button_Adiciona.UseVisualStyleBackColor = true;
            this.button_Adiciona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_Adiciona_KeyPress);
            this.button_Adiciona.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Adiciona_MouseClick);
            // 
            // button_Limpar
            // 
            this.button_Limpar.Location = new System.Drawing.Point(184, 56);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpar.TabIndex = 5;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Limpar_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.button_Adiciona);
            this.Controls.Add(this.textBox_listaNomes);
            this.Controls.Add(this.textBox_nomesJogadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro de Jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_nomesJogadores;
        private TextBox textBox_listaNomes;
        private Button button_Adiciona;
        private Button button_Limpar;
    }
}