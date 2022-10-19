using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCadastrar_lista9
{
    internal class Cadastro
    {
        public static void gravarNome(string nome, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nome);
            escritor.WriteLine(nome.ToUpper());
            escritor.Flush();
            escritor.Close();
        }

        public static void populaArquivo(List<string> listaNomes, string nome)
        {
            StreamReader lerArquivo = new StreamReader(nome, Encoding.UTF8);
            do
            {
                listaNomes.Add(lerArquivo.ReadLine());
            } while (!lerArquivo.EndOfStream);
        }
    }
}
