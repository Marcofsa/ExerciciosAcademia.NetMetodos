using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTvControleRemoto
{
    internal class Televisao
    {
        public class Televisao
        {
            public string marca { get; set; }
            public string modelo { get; set; }
            public int volume { get; set; }
            public int volumeMax { get; set; }
            public double canal { get; set; }
            public double canalMin { get; set; }
            public double canalMax { get; set; }


            public Televisao(string marca, string modelo, int volume, int volumeMax, double canal, double canalMin, double canalMax)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.volumeMax = volumeMax;
                this.volume = volume;
                this.canal = canal;
                this.canalMin = canalMin;
                this.canalMax = canalMax;
            }

            public void aumentaVolume()
            {
                if (volume < volumeMax)
                {
                    this.volume++;
                    Console.WriteLine("Volume " + volume);
                }
                else
                {
                    Console.WriteLine("Volume máximo!");
                }
            }
            public void diminuiVolume()
            {
                if (volume > 0)
                {
                    this.volume--;
                    if (volume == 0)
                    {
                        Console.WriteLine("Mute: On");
                    }
                    else
                    {
                        Console.WriteLine("Volume " + volume);
                    }
                }
                else
                {
                    Console.WriteLine("Mute: On");
                }
            }
            public void avancaCanal()
            {
                if (canal >= canalMax)
                {
                    this.canal = canalMin;
                }
                else
                {
                    this.canal++;
                }
                Console.WriteLine("Canal " + canal);
            }
            public void voltaCanal()
            {
                if (canal <= canalMin)
                {
                    this.canal = canalMax;
                }
                else
                {
                    this.canal--;
                }
                Console.WriteLine("Canal " + canal);
            }

            public void trocaCanal()
            {
                Console.Write("Qual canal deseja alternar? ");
                this.canal = double.Parse(Console.ReadLine());
                Console.WriteLine("canal: {0}", this.canal);
            }

            public void volCanInfo()
            {
                Console.WriteLine("Volume: {0}          Canal: {1}", this.volume, this.canal);
            }
        }
}
