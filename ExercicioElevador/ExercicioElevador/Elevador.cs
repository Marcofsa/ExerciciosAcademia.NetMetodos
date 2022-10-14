using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioElevador
{
    public class Elevador
    {
        public int andar { get; set; }
        public int andares { get; set; }
        public int pessoas { get; set; }
        public float capacidade { get; set; }

        public void inicializa(float capacidade, int andares)
        {
            this.capacidade = capacidade;
            this.andares = andares;
            this.pessoas = 0;
        }

        public void entra()
        {
            if (pessoas <= capacidade)
            {
                pessoas++;
                Console.WriteLine("{0}/{1} ocupado.\n", pessoas, capacidade);
            }
            else
            {
                Console.WriteLine("Elevador lotado.\n");
            }
        }

        public void sai()
        {
            if (pessoas > 0)
            {
                pessoas--;
                Console.WriteLine("{0}/{1} ocupado.\n", pessoas, capacidade);
            }
            else
            {
                Console.WriteLine("O elevador está vazio.\n");
            }
        }

        public void subir()
        {
            if (andar + 1 <= andares)
            {
                andar++;
                Console.WriteLine("Subindo para o {0}º andar...\n", andar);
            }
            else
            {
                Console.WriteLine("Não foi possível subir. Já estamos no último andar...\n");

            }
        }
        public void descer()
        {
            if (andar - 1 >= 0)
            {
                if (andar == 0)
                {

                }
                andar--;
                Console.WriteLine("Descendo para o {0}º andar...\n", andar);
            }
            else
            {
                Console.WriteLine("Não foi possível descer. Já estamos no térreo...\n");
            }
        }
    }
}
