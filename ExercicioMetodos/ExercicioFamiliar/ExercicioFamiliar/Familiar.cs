using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFamiliar
{
    internal class Familiar
    {
        private string nome;
        private int idade;
        private double altura;
        private double peso;
        private string sexo;
        private string olhos;
        private string cabelos;
        private string raca;
        private string pai;
        private string mae;

        public Familiar(string nome, int idade, double altura, double peso, string sexo, string olhos, string cabelos, string raca, string pai, string mae)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.olhos = olhos;
            this.cabelos = cabelos;
            this.raca = raca;
            this.pai = pai;
            this.mae = mae;
        }

        public void getFamiliar()
        {
            Console.Clear();
            Console.WriteLine("{0} cadastrado(a)!", nome);
            Console.WriteLine("{0} anos, {1}m de altura e {2}kg", idade, altura, peso);
            Console.WriteLine("Sexo {0}, olhos {1}, cabelos {2} e raça {3}", sexo, olhos, cabelos, raca);
            Console.WriteLine("Pai '{0}'  Mãe '{1}'", pai, mae);
        }
    }
}
