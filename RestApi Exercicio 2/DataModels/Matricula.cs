namespace RestApi_Exercicio_2.DataModels
{
    public class Matricula
    {
        public int id { get; set; }
        public DateTime data { get; set; }        
        public int idAluno { get; set; }
        public int idCurso { get; set; }
    }
}
