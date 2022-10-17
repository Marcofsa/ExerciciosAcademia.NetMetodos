using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCenario
{
    internal class Cena
    {
        private string _descricao { get; set; }
        private DateTime _data { get; set; }
        private float _altura { get; set; }


        public Cena (string descricao, DateTime data, float altura)
        {
            Descricao = descricao;
            Data = data;
            Altura = altura;
        }

        public string Descricao { get => _descricao; set => _descricao = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public float Altura { get => _altura; set => _altura = value; }
        
        public static void DetalhesCena(List<Cena> c, int index)
        {
            Console.WriteLine("Descrição: {0}", c[index].Descricao);
            Console.WriteLine("Criado em: {0}", c[index].Data);
            Console.WriteLine("{0}m\n", c[index].Altura);
        }
        public static void TempoItem(List<Cena>c, int index)
        {
            DateTime agora = DateTime.Now;
            TimeSpan dif = agora.Subtract(c[index].Data);

            int dias = (int)dif.TotalDays;
            int horas = (int)dif.TotalHours;
            int minutos = (int)dif.TotalMinutes;
            int segundos = (int)dif.TotalSeconds;
            Console.WriteLine("\nO Cenário possui ");
            if (dias > 0)
            {
                if (dias == 0)
                {
                    Console.Write($"{dias} dia, ");
                }
                else if (dias > 1)
                {
                    Console.WriteLine($"{dias} dias, ");
                }
            }
            if (horas > 0)
            {
                if (horas == 0)
                {
                    Console.Write($"{horas} horas, ");
                }
                else if (dias > 1)
                {
                    Console.WriteLine($"{horas} horas, ");
                }
            }
            if (minutos > 0)
            {
                if (minutos == 0)
                {
                    Console.Write($"{minutos} minutos, ");
                }
                else if (minutos > 1)
                {
                    Console.WriteLine($"{minutos} minutos, ");
                }
            }
            if (segundos > 0)
            {
                if (segundos == 0)
                {
                    Console.Write($"{segundos} segundos, ");
                }
                else if (segundos > 1)
                {
                    Console.WriteLine($"{segundos} segundos, ");
                }
            }
            Console.WriteLine("de sua criação.");
        }
    }
}
