﻿namespace GerenciadorDeTarefasComAutenticacaoAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
