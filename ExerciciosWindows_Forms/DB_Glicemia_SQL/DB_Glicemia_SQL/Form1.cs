using System.Configuration;
using System.Linq.Expressions;
using Microsoft.Data.SqlClient;

namespace DB_Glicemia_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectString = "Data Source=localhost; Initial Catalog=glicemia_db; User ID=usuario; password=senha;language=Portuguese";
        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(connectString);
            conexao.Open();
            try
            {
              string sqlTexto = "SELECT [MedidaGlicemia].idMedidaGlicemia, [MedidaGlicemia].valorGlicemia, [MedidaGlicemia].dataMedida,[Paciente].nome,[Paciente].idPaciente FROM MedidaGlicemia, Paciente WHERE[MedidaGlicemia].idPaciente = [Paciente].idPaciente";
              SqlCommand comando = new SqlCommand (sqlTexto, conexao);
                listView1.Items.Clear();

                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                string[] vetorDados;
                while (leitor.Read())
                {
                    listView1.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    listView1.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    vetorDados = leitor["dataMedida"].ToString().Split(' ');
                    listView1.Items[i].SubItems.Add(vetorDados[0]);
                    listView1.Items[i].SubItems.Add(leitor["nome"].ToString());
                    listView1.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                    i++;
                }
                conexao.Close();
                button_connect.Enabled = true;
            } 
            catch (Exception)
            {
                MessageBox.Show("ATENÇÃO!\n NÃO CONECTADO AO SERVIDOR!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            carregarListView();
            button_Cadastrar.Enabled = true;
        }
        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            panel_campos.Enabled = true;

            textBox_idMedida.Text = "" + (int.Parse(listView1.Items[listView1.Items.Count - 1].SubItems[0].Text) + 1);
            textBox_valorGlicemia.Text = "";
            textBox_dataMedicao.Text = "";
            textBox_idPaciente.Text = "";
        }
        private void button_gravar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(connectString);
            conexao.Open();
            try
            {

                int idMedidaGlicemia = int.Parse(textBox_idMedida.Text);
                int valorGlicemia = int.Parse(textBox_valorGlicemia.Text);
                string dataMedida = textBox_dataMedicao.Text;
                int idPaciente = int.Parse(textBox_idPaciente.Text);

                string sqlUpdate = "UPDATE MedidaGlicemia SET valorGlicemia = @valorGlicemia, dataMedida = @dataMedida, idPaciente = @idPaciente WHERE idMedidaGlicemia = @idMedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlUpdate, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                int contadorLinhas = comando.ExecuteNonQuery();
                MessageBox.Show("FEITO!");

                if (contadorLinhas < 1)
                {
                    string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                    comando = new SqlCommand(sqlTexto, conexao);
                    comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                    comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                    comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                    comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                    comando.ExecuteNonQuery();
                }
                conexao.Close();
                carregarListView();

                panel_campos.Enabled = false;
            }

            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS DE CONECTIVIDADE COM O BANCO DE DADOS" + e.ToString(), "CUIDADO!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(connectString);
            conexao.Open();

            try
            {
                int idMedidaGlicemia = int.Parse(listView1.SelectedItems[0].Text);
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                comando.ExecuteNonQuery();
                conexao.Close();

                carregarListView();

                button_Cadastrar.Enabled = true;
                button_Deletar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS DE CONECTIVIDADE COM O BANCO DE DADOS" + e.ToString(), "CUIDADO!");
            }  
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Deletar.Enabled = true;
            button_Cadastrar.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_campos.Enabled = true;
            SqlConnection conexao = new SqlConnection(connectString);
            conexao.Open();

            try
            {
                int idMedidaGlicemia = int.Parse(listView1.SelectedItems[0].Text);
                string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                SqlDataReader leitor = comando.ExecuteReader();

                leitor.Read();
                textBox_idMedida.Text = leitor["idMedidaGlicemia"].ToString();
                textBox_valorGlicemia.Text = leitor["valorGlicemia"].ToString();

                string[] vetorDados;
                vetorDados = leitor["dataMedida"].ToString().Split();
                textBox_dataMedicao.Text = vetorDados[0];
                textBox_idPaciente.Text = leitor["idPaciente"].ToString();

                conexao.Close();
                carregarListView();
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS DE CONECTIVIDADE COM O BANCO DE DADOS" + e.ToString(), "CUIDADO!");
            }
        }
    }
}