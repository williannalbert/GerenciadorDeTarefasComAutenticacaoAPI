namespace GerenciadorDeTarefasComAutenticacaoAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual Tarefa Tarefa { get; set; }
    }
}
