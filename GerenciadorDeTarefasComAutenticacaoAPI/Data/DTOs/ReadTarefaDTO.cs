using GerenciadorDeTarefasComAutenticacaoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Data.DTOs
{
    public class ReadTarefaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Prazo { get; set; }
        public bool Concluido { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
