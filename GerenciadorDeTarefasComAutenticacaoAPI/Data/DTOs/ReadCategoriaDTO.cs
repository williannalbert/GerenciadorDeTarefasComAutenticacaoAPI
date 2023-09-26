    using GerenciadorDeTarefasComAutenticacaoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Data.DTOs
{
    public class ReadCategoriaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
