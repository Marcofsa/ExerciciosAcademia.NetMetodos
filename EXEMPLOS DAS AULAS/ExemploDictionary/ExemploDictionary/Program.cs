namespace ExemploDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>()
            {
                {1, "Banana" },
                {2, "Maçã" },
                {3, "Abacate" },
                {4, "Mamão" },
                {5, "Manga" }
            };
            string result;
            if (dic1.TryGetValue(4, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Não é possível achar o especificado.");
            }
        }
        //Console.WriteLine(dic1.ContainsKey(1)); //RETORNA TRUE
        //Console.WriteLine(dic1.ContainsKey(6));//RETORNA FALSE

        //Console.WriteLine(dic1.ContainsKey("Manga"));
        //Console.ReadKey();
        //Console.ReadKey();

    }
 }
