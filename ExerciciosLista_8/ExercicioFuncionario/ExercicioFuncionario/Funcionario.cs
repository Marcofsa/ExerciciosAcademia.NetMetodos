using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionario
{
    internal class Funcionario
    {
        private string _nome { get; set; }
        private string _departamento { get; set; }
        private double _salario { get; set; }
        private string _dataEntrada { get; set; }
        private string _rg { get; set; }
        private bool _ativo { get; set; }
        public Funcionario(string nome, string departamento, double salario, string dataEntrada, string rg, bool ativo)
        {
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            DataEntrada = dataEntrada;
            Rg = rg;
            Ativo = ativo;
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            DataEntrada = dataEntrada;
            Rg = rg;
            Ativo = ativo;
        }
        public string Nome { get => _nome; set => _nome = value; }
        public string Departamento { get => _departamento; set => _departamento = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public string DataEntrada { get => _dataEntrada; set => _dataEntrada = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        //public static void Bonifica(List<Funcionario> f, double valor)
        //{
        //    Salario += valor;
        //    Console.WriteLine($"O salário do {Nome} aumentou para {Salario:C}");
        //}

        public void Demite()
        {
            Ativo = false;
            Console.WriteLine($"Funcionário {Nome} demitido...");
        }

    }
}
