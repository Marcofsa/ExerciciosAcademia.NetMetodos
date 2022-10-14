namespace ExemploDict2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary <string, int> dict2 = new SortedDictionary<string, int>();
            dict2.Add("Zebra", 5);
            dict2.Add("Cachorro", 2);
            dict2.Add("Gato", 9);
            dict2.Add("Pardal", 4);
            dict2.Add("C#", 100);

            if (dict2.ContainsKey("Gato"))
            {
                Console.WriteLine("Contém um gato.");
            }
            if (dict2.ContainsKey("Zebra"))
            {
                Console.WriteLine("Contém uma zebra.");
            }
            int v;
            if (dict2.TryGetValue("C#", out v))
            {
                Console.WriteLine(v);
            }
            foreach(KeyValuePair<string, int>p in dict2)
            {
                Console.WriteLine(p.Key+" "+p.Value);
            }
            Console.ReadKey();

        }
    }
}