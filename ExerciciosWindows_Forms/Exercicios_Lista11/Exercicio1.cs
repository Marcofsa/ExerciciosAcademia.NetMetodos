namespace Exercicios_Lista11
{
    public partial class frmEx1 : Form
    {
        /*
         * 1. Fazer um programa em VS e com Windows Forms.
         * A interface gráfica precisa ter 
         * - Labels
         * - TextBox
         * - Button
         * - Panel
         * - List 
         * - Classe específica
         * 
         * O programa dever permitir que o usuário cadastre nomes completos obrigatoriamente.
         * Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo 
         * duas palavras e que não esteja na lista. Ao final, caso o nome não esteja na lista,
         * cadastra-lo em maiúsculo e exibir a lista ordenada em um componente gráfico equivalente.
        */

        List<string> nomes = new List<string>();
        int quant = 0;
        public frmEx1()
        {
            InitializeComponent();
            lblQuant.Text = $"{quant} nomes cadastrados";
        }

        //método que trata evento de um componente
        private void btnAddList_Click(object sender, EventArgs e)
        {
            inserirTextBox_lista();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                inserirTextBox_lista();
            }
        }

        private void inserirTextBox_lista()
        {
            string nome = txtNome.Text.ToUpper();
            string[] validaNome = nome.Split(" ");

            if (validaNome.Length < 2)
            {
                MessageBox.Show("Favor preencha o nome completo no campo 'nome completo'", "ATENÇÃO!");
            }
            else
            {
                if (nomes.Contains(nome))
                {
                    MessageBox.Show($"'{nome}' já existe na lista!");
                }
                else
                {
                    nomes.Add(nome);
                    nomes.Sort();
                }
            }
            
            quant = nomes.Count;
            txtLista.Clear();
            foreach(var n in nomes)
            {
                txtLista.Text += n + Environment.NewLine;
            }
            txtNome.Clear();
            lblQuant.Text = $"{quant} nomes cadastrados";
            txtNome.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            lblHora.Text = dt.ToString();
        }
    }
}