namespace Unico.Domain.Entities
{
    public class Tarefa : BaseEntity
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; }

    }
}
