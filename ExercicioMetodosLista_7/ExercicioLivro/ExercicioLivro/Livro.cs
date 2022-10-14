using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLivro
{
    internal class Livro
    {
        private string titulo;
        private string autor;
        private int paginas;
        private string capa;

        public Livro (string titulo, string autor, int paginas, string capa)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
            this.capa = capa;
        }
        public void getLivro()
        {
            Console.Clear();
            Console.WriteLine("Livro '{0}' cadastrado!", titulo);
            Console.WriteLine("Autor: '{0}' ", autor);
            Console.WriteLine("{0} páginas. Capa {1}", paginas, capa);


        }
    }
}
