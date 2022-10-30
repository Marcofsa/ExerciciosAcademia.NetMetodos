using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Lista11
{
    public partial class frmEx2 : Form
    {
        /*
         * 2. Fazer um programa em VS e com windows Forms.
         * A interface gráfica precisa ter 
         * - Labels
         * - TextBox
         * - Button
         * - Panel
         * - List 
         * - Classe específica
         * 
         * O programa deve possuir botões (como um menu) para com cadastrar emails, listar emails 
         * e limpar conteúdo dos componentes. Os emails digitados devem ser cadastrados em uma lista 
         * e não pode haver emails duplicados, ou seja, o programa deve controlar essa situação. 
         * Quando o usuário solicitar a listagem dos emails, além dessa lista, o programa deve listar
         * os domínios de emails cadastrados no programa. Para isso, usar dois componentes gráficos
         * equivalentes.
         */ 
         
        public frmEx2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            lstEmails.Clear();
            lstDominios.Clear();
            txtNome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string[] validaEmail = email.Split("@");

            if (nome.Length < 3)
            {
                MessageBox.Show("Favor preencher um nome!");                
            }

            if (validaEmail.Length < 2)
            {
                MessageBox.Show("Favor preencher um e-mail válido!");                
            }
            else
            {

            }
        }
    }
}
