using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAsteroids
{
    internal class Asteroides
    {
        private float _posX { get; set; }
        private float _posY { get; set; }
        private int _tamanho { get; set; }
        private int _velocidade { get; set; }
        private int _energia { get; set; }

        List<Asteroides> asteroide = new List<Asteroides>();
        public Asteroides() { }

        public Asteroides(float posX, float posY, int tamanho, int velocidade, int energia)
        {
            _posX = posX;
            _posY = posY;
            _tamanho = tamanho;
            _velocidade = velocidade;
            _energia = energia;

            Console.WriteLine("Asteroide cadastrado!");
        }

        public Asteroides(float posX, float posY)
        {
            _posX = posX;
            _posY = posY;
        }

        public void CadastraAsteroide(float posX, float posY, int tamanho)
        {
            //Asteroides(posX, posY, tamanho);
        }
        public void getAsteroides()
        {
            foreach (Asteroides a in asteroide)
            {
                Console.WriteLine("X: {0}   Y: {1}   Tamanho: {2}   Velocidade: {3} Mph   Energia: {4}", a._posX, a._posY, a._tamanho, a._velocidade);
            }
        }
    }
}
