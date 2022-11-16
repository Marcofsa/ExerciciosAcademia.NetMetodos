using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aulaDB_Pessoas
{
    internal class Banco
    {
        private string conec = "Data Source=localhost;Initial Catalog=aula;" + "User ID=usuarioAtos; password=senha; language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable executaConsulta(string sql)
        {
           try
            {
               abrirConexao();
               SqlCommand cmd = new SqlCommand(sql, cn);
               cmd.ExecuteNonQuery();

               SqlDataAdapter adapter = new SqlDataAdapter(cmd);
               DataTable dt = new DataTable();
               adapter.Fill(dt);
               return dt;
             }
               catch (Exception ex)
             {
                    return null;
             }

              finally
              {
                    fecharConexao();
              }
        }
       
    }
}
