namespace ExercicioFamilia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaFilho = new Pessoa();
            
            pessoaFilho.idade = 12;
            
            pessoaFilho.nome = "Diego";
            
            Pessoa pessoaMae = new Pessoa();
            
            pessoaMae.nome = "Erika";
            
            pessoaMae.idade = 35;
            
            Pessoa pessoaPai = new Pessoa();
            
            pessoaPai.nome = "Sergio";
            
            pessoaPai.idade = 31;
            
            Pessoa pAvoPai = new Pessoa();
            
            pAvoPai.nome = "João";
           
            pAvoPai.idade = 62;
            
            pessoaPai.pai = pAvoPai;
           
            pessoaFilho.mae = pessoaMae;
            
            pessoaFilho.pai = pessoaPai;
        }
    }
}