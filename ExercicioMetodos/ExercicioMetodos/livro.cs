using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodos
{
    internal class livro
    {
        public string nome;
        public int paginas;
        public string cor;
        public string categoria;
        public livro()
        {
            nome = "Battlefield";
            paginas = 400;
            cor = "azul";
            categoria = "guerra";
        }
        public void nomeLivro(string nome)
        {
            Console.WriteLine("O nome do livro é: " + nome);

        }
        public void paginasQuantidade()
        {
            Console.WriteLine("O livro tem " + paginas +" :");
        }
        public void qualCategoria()
        {
            Console.WriteLine("A categoria do livro é: " +categoria);

        }
        public void corCapa()
        {
            Console.WriteLine("A cor da capa do livro é: "+cor);
        }

    }
}
