namespace ExercicioCadastrar_lista9
{
    internal class Program
    {
     //QUESTAO 1
        static void Main(string[] args)
        {
            string nome ="";
            List<string> listaNomes = new List<string>();

            while (true)
            {
                Console.WriteLine("Digite o nome e o sobrenome do usuário ou digite Sair para sair do programa.");
                if (nome.ToUpper()=="SAIR")
                {
                    break;
                }
                if (listaNomes.Contains(nome.ToUpper()))
                {
                    Console.WriteLine("NOME JÁ CADASTRADO!");

                }
                else
                {
                    listaNomes.Add(nome);
                    Cadastro.gravarNome(nome, @"C:\GIT New ACADEMIA\ExerciciosAcademia.NetMetodos\ExercicioCadastrar_lista9\Cadastro de nomes.txt");
                }

            }
        }
    }
}