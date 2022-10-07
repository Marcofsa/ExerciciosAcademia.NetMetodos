namespace ExercicioMetodos_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma temperatura em Fahrenheit: ");
            
            Temperatura temp = new Temperatura();
            
            temp.setCelsius = double.Parse(Console.ReadLine());
            
            Console.WriteLine("----------------------------");
            
            Console.WriteLine(temp.getCelsius());
       }
    }
}