namespace Exercicios_Lista11
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.sts1 = new System.Windows.Forms.StatusStrip();
            this.lblQuant = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sts1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNome.Location = new System.Drawing.Point(136, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Digite seu nome completo";
            this.txtNome.Size = new System.Drawing.Size(225, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(367, 5);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(115, 23);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "Inserir";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(12, 34);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(460, 252);
            this.txtLista.TabIndex = 3;
            // 
            // sts1
            // 
            this.sts1.AutoSize = false;
            this.sts1.Dock = System.Windows.Forms.DockStyle.None;
            this.sts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblQuant,
            this.lblHora});
            this.sts1.Location = new System.Drawing.Point(0, 289);
            this.sts1.Name = "sts1";
            this.sts1.Size = new System.Drawing.Size(484, 22);
            this.sts1.TabIndex = 4;
            this.sts1.Text = "statusStrip1";
            // 
            // lblQuant
            // 
            this.lblQuant.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(0, 17);
            this.lblQuant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Margin = new System.Windows.Forms.Padding(225, 3, 0, 2);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 17);
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.sts1);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula 26/10/2022";
            this.sts1.ResumeLayout(false);
            this.sts1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnAddList;
        private TextBox txtLista;
        private StatusStrip sts1;
        private ToolStripStatusLabel lblQuant;
        private ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}