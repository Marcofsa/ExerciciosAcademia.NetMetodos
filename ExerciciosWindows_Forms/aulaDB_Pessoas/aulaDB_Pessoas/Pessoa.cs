using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaDB_Pessoas
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public float peso;

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into pessoas values (@nome, @peso);";
            com.Parameters.Add("@nome", SqlDbType.VarChar);
            com.Parameters.Add("@peso", SqlDbType.Float);
            com.Parameters[0].Value = nome;
            com.Parameters[1].Value = peso;

            try
            {
                com.ExecuteNonQuery();
                transacao.Commit();
                return true;

            }
            catch(Exception ex)
            {
                transacao.Rollback();
                return false;
                
            }
            finally
            {
                bd.fecharConexao();
            }

        }
    }
}
