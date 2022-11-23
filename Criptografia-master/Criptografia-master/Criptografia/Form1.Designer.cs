namespace Criptografia
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
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCripto = new System.Windows.Forms.Label();
            this.txbChave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescripto = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblChavePublica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbFrase
            // 
            this.txbFrase.Location = new System.Drawing.Point(155, 39);
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.Size = new System.Drawing.Size(256, 23);
            this.txbFrase.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chave Simétrica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frase criptografada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCripto
            // 
            this.lblCripto.AutoSize = true;
            this.lblCripto.Location = new System.Drawing.Point(261, 133);
            this.lblCripto.Name = "lblCripto";
            this.lblCripto.Size = new System.Drawing.Size(12, 15);
            this.lblCripto.TabIndex = 4;
            this.lblCripto.Text = "-";
            this.lblCripto.UseMnemonic = false;
            // 
            // txbChave
            // 
            this.txbChave.Location = new System.Drawing.Point(484, 39);
            this.txbChave.Name = "txbChave";
            this.txbChave.Size = new System.Drawing.Size(100, 23);
            this.txbChave.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chave";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Descripto Simétrica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Frase descriptografada";
            // 
            // lblDescripto
            // 
            this.lblDescripto.AutoSize = true;
            this.lblDescripto.Location = new System.Drawing.Point(261, 232);
            this.lblDescripto.Name = "lblDescripto";
            this.lblDescripto.Size = new System.Drawing.Size(12, 15);
            this.lblDescripto.TabIndex = 9;
            this.lblDescripto.Text = "-";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Chave Assimetrica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblChavePublica
            // 
            this.lblChavePublica.AutoSize = true;
            this.lblChavePublica.Location = new System.Drawing.Point(493, 93);
            this.lblChavePublica.Name = "lblChavePublica";
            this.lblChavePublica.Size = new System.Drawing.Size(12, 15);
            this.lblChavePublica.TabIndex = 11;
            this.lblChavePublica.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 339);
            this.Controls.Add(this.lblChavePublica);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblDescripto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbChave);
            this.Controls.Add(this.lblCripto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbFrase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbFrase;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label lblCripto;
        private TextBox txbChave;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label lblDescripto;
        private Button button3;
        private Label lblChavePublica;
    }
}