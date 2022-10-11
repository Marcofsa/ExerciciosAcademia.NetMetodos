namespace ListasOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de
             * realizar as seguintes operações:
  void armazenaPessoa(String nome, int idade, float altura);
  void removePessoa(String nome);
  Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
  void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda 
            Crie uma classe Estacionamento onde 10 automoveis podem estar estacionados.
            Realizar as operaçoes:
            void armazenaCarro(String marca, String modelo, String placa)
            void removeCarro (String placa)
            Carro BuscaCarro(string placa)*/
            
            //Console.WriteLine("Hello, World!");
            //Carro c = new Carro("VW", "Fusca", "ABC-1234");
            //c.MostraDados();
            int op;
            Estacionamento e = new Estacionamento("Estacionamento do Centro");
            string fabricante;
            string modelo;
            string placa;
            Carro consulta = null;
            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar carro\nDigite 2 para buscar as informações \nDigite 3 para apagar carro\nDigite 4 para sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Digite o fabricante do carro: ");
                    fabricante = Console.ReadLine();
                    Console.WriteLine("Digite o modelo do carro: ");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Digite a placa do carro: ");
                    placa = Console.ReadLine();
                    e.ArmazenaCarro(fabricante, modelo, placa);
                    /*e.ArmazenaCarro("VW", "Fusca", "ABC-1234");
                    e.ArmazenaCarro("Ford", "Belina", "IEJ8115");*/
                    Console.Clear();
                    e.MostraEstacionados();
                }
                if (op == 2)
                {
                    Console.WriteLine("Digite a placa do automovel que sairá: ");
                    placa = Console.ReadLine();
                    consulta = e.BuscaCarro(placa);
                    if (consulta != null)
                    {
                        Console.WriteLine("Carro ENCONTRADO! Modelo: " + consulta.modelo + " Placa " + consulta.placa);

                    }
                    else
                    {
                        Console.WriteLine("Carro não encontrado!");
                    }
                }
                if (op == 3)
                {
                    Console.WriteLine("Digite a placa do automovel que sairá: ");
                    placa = Console.ReadLine();
                }
                if (op == 4)
                {
                    break;
                }
            }
            
        }
    }
}