using System.Diagnostics;

namespace Exercicio_Jogador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string linha;
            string[] vetorDados;
            InitializeComponent();
            StreamReader leitor = new StreamReader("jogadores.txt");
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");
                lista_nomesJogadores.Add(new Jogador(vetorDados[0], vetorDados[1]));
                textBox_listaNomes.AppendText(vetorDados[0] + " . " + vetorDados[1] + Environment.NewLine);
            }while(leitor.EndOfStream);
            leitor.Close();
        }
        string email;

        private void button_Adiciona_MouseClick(object sender, MouseEventArgs e)
        {
           

            textBox_nomesJogadores.Text = textBox_nomesJogadores.Text.ToUpper();
            if (Jogador.jaCadastrado(textBox_nomesJogadores.Text, lista_nomesJogadores))
            {
                MessageBox.Show( "Jogador já cadastrado!", "CUIDADO!");
            }
            else
            {
                string[] vetorNomes = textBox_nomesJogadores.Text.ToLower().Split(" ");
                if (vetorNomes.Length > 1)
                {
                    email = vetorNomes[vetorNomes.Length - 1] + " . " + vetorNomes[0] + "@ufn.edu.br";
                }
                else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";
                }

                lista_nomesJogadores.Add(new Jogador(textBox_nomesJogadores.Text, email) );
                textBox_listaNomes.AppendText(textBox_nomesJogadores.Text + " . " + email + Environment.NewLine);
            }
            textBox_nomesJogadores.Text = "";

            StreamWriter escritor = new StreamWriter("jogadores.txt", true);
            escritor.WriteLine(textBox_nomesJogadores + ";" + email);
            escritor.Close();
        }

        private void button_Limpar_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_listaNomes.Text = "";
            textBox_nomesJogadores.Text = "";
            lista_nomesJogadores.Clear();
        }
        List<Jogador> lista_nomesJogadores = new List<Jogador>(); 

    }
}