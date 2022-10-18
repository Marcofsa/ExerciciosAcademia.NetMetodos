using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAsteroids
{
    internal class Asteroides
    {
        internal class Asteroide
        {
            private int posicao_x;
            private int posicao_y;
            private int tamanho;//1 a 10
            private int velocidade; //1 a 5
            private int energia; //1 a 5



            public int Posicao_x { get; set; }
            public int Posicao_y { get; set; }
            public int Tamanho { get; set; }
            public int Velocidade { get; set; }
            public int Energia { get; set; }

            //CONSTRUTORES
            public Asteroide()
            {



            }
            public Asteroide(int posicao_x, int posicao_y, int tamanho, int velocidade, int energia)
            {
                this.Posicao_x = posicao_x;
                this.Posicao_y = posicao_y;
                this.Tamanho = tamanho;
                this.Velocidade = velocidade;
                this.Energia = energia;
            }
            public Asteroide(int posicao_x, int posicao_y)
            {
                this.Posicao_x = posicao_x;
                this.Posicao_y = posicao_y;
            }
        }
    }
    }
}
