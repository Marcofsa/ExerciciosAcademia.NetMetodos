using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEIRO_WF_ADONET
{
    internal class Departamento
    {
        public string nome;
        public string localizacao;
        public string orcamento;
        public Departamento()
        {

        }
        public bool gravarDepartamento()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran =cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandText = CommandType.Text;

            cmd.CommandText = "INSERT  INTO VALUES (@nome, @localizacao, @orcamento);";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@localizacao", SqlDbType.VarChar);
            cmd.Parameters.Add("@orcamento", SqlDbType.VarChar);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = localizacao;
            cmd.Parameters[2].Value = orcamento;
            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true; 
            }
            catch
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }
    }
}
