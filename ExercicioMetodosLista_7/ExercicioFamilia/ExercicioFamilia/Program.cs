namespace ExercicioFamilia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaFilho = new Pessoa();
            
            pessoaFilho.idade = 12;
            
            pessoaFilho.nome = "Joaquim";
            
            Pessoa pessoaMae = new Pessoa();
            
            pessoaMae.nome = "Marcia";
            
            pessoaMae.idade = 35;
            
            Pessoa pessoaPai = new Pessoa();
            
            pessoaPai.nome = "Deca";
            
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