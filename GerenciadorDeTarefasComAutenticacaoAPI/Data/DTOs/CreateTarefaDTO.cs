﻿using GerenciadorDeTarefasComAutenticacaoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Data.DTOs
{
    public class CreateTarefaDTO
    {
        [Required(ErrorMessage = "Preenchimento obrigatório do nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório de descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório da data de criação")]
        public DateTime DataCriacao { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório do prazo")]
        public DateTime Prazo { get; set; }
        public bool Concluido { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatório de categoria")]
        public int CategoriaId { get; set; }
    }
}
