namespace ExemploWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\garen\OneDrive\Área de Trabalho\CURSO DotNet\atos.txt");
            writer.WriteLine("Today is Monday!");
            writer.WriteLine("Aula exemplo atos.");
            writer.WriteLine();
            writer.WriteLine();
            writer.WriteLine("17/10/2022");
            writer.Close();
        }
    }
}