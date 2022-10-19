using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLivro
{
    internal class Livro
    {
        class Livros
        {
            private string _titulo { get; set; }
            private int _paginas { get; set; }

            public Livros() { }
            public Livros(string titulo, int paginas)
            {
                Titulo = titulo;
                Paginas = paginas;
            }
            public string Titulo { get => _titulo; set => _titulo = value; }
            public int Paginas { get => _paginas; set => _paginas = value; }
        }
    }
}
