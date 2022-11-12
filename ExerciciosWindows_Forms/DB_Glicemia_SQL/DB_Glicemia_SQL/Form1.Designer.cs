namespace DB_Glicemia_SQL
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Deletar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.textBox_dataMedicao = new System.Windows.Forms.TextBox();
            this.textBox_valorGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_idMedida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_gravar = new System.Windows.Forms.Button();
            this.panel_campos = new System.Windows.Forms.Panel();
            this.panel_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(29, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(645, 126);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idMedida";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicêmico";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "idPaciente";
            this.columnHeader5.Width = 80;
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_connect.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_connect.Location = new System.Drawing.Point(29, 144);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(110, 37);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Conectar";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Cadastrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Cadastrar.Location = new System.Drawing.Point(145, 144);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(110, 37);
            this.button_Cadastrar.TabIndex = 2;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = false;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Deletar
            // 
            this.button_Deletar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Deletar.ForeColor = System.Drawing.Color.Red;
            this.button_Deletar.Location = new System.Drawing.Point(261, 144);
            this.button_Deletar.Name = "button_Deletar";
            this.button_Deletar.Size = new System.Drawing.Size(110, 37);
            this.button_Deletar.TabIndex = 3;
            this.button_Deletar.Text = "Deletar";
            this.button_Deletar.UseVisualStyleBackColor = false;
            this.button_Deletar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(377, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.Location = new System.Drawing.Point(105, 121);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(212, 23);
            this.textBox_idPaciente.TabIndex = 5;
            // 
            // textBox_dataMedicao
            // 
            this.textBox_dataMedicao.Location = new System.Drawing.Point(105, 92);
            this.textBox_dataMedicao.Name = "textBox_dataMedicao";
            this.textBox_dataMedicao.Size = new System.Drawing.Size(212, 23);
            this.textBox_dataMedicao.TabIndex = 6;
            // 
            // textBox_valorGlicemia
            // 
            this.textBox_valorGlicemia.Location = new System.Drawing.Point(105, 63);
            this.textBox_valorGlicemia.Name = "textBox_valorGlicemia";
            this.textBox_valorGlicemia.Size = new System.Drawing.Size(212, 23);
            this.textBox_valorGlicemia.TabIndex = 7;
            // 
            // textBox_idMedida
            // 
            this.textBox_idMedida.Location = new System.Drawing.Point(105, 34);
            this.textBox_idMedida.Name = "textBox_idMedida";
            this.textBox_idMedida.Size = new System.Drawing.Size(212, 23);
            this.textBox_idMedida.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "idGlicemia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor Glicemia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Medição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "idPaciente";
            // 
            // button_gravar
            // 
            this.button_gravar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_gravar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_gravar.Location = new System.Drawing.Point(105, 150);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(100, 40);
            this.button_gravar.TabIndex = 13;
            this.button_gravar.Text = "Salvar";
            this.button_gravar.UseVisualStyleBackColor = false;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // panel_campos
            // 
            this.panel_campos.Controls.Add(this.label1);
            this.panel_campos.Controls.Add(this.button_gravar);
            this.panel_campos.Controls.Add(this.textBox_idMedida);
            this.panel_campos.Controls.Add(this.label2);
            this.panel_campos.Controls.Add(this.textBox_idPaciente);
            this.panel_campos.Controls.Add(this.textBox_valorGlicemia);
            this.panel_campos.Controls.Add(this.label3);
            this.panel_campos.Controls.Add(this.label4);
            this.panel_campos.Controls.Add(this.textBox_dataMedicao);
            this.panel_campos.Location = new System.Drawing.Point(29, 187);
            this.panel_campos.Name = "panel_campos";
            this.panel_campos.Size = new System.Drawing.Size(320, 216);
            this.panel_campos.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.panel_campos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_Deletar);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "TABELA GLICÊMICA";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_campos.ResumeLayout(false);
            this.panel_campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private Button button_connect;
        private Button button_Cadastrar;
        private Button button_Deletar;
        private Button button4;
        private TextBox textBox_idPaciente;
        private TextBox textBox_dataMedicao;
        private TextBox textBox_valorGlicemia;
        private TextBox textBox_idMedida;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button_gravar;
        private Panel panel_campos;
    }
}