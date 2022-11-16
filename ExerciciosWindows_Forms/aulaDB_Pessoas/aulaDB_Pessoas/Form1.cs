using System.Data;

namespace aulaDB_Pessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBox_Nome.Text;
            p.peso = float.Parse(textBox_Peso.Text);

            if (p.gravar())
            {
                MessageBox.Show("PESSOA ADICIONADA COM SUCESSO!");
            }
            else
            {
                MessageBox.Show("ERRO AO ADICIONAR A PESSOA!");
            }
        }

        private void botao_Consulta_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from pessoas");

            dataGridView1.DataSource = dt;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = bd.executaConsulta("SELECT * FROM Pessoas WHERE nome LIKE '%" + textBox_Busca.Text + "%'");
        }
    }
}