namespace AppMediatorCQRS.Models
{
    public class Pessoa : EntityBase
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}
