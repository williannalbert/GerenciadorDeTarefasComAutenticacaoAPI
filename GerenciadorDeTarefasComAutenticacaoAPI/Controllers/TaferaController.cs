using AutoMapper;
using GerenciadorDeTarefasComAutenticacaoAPI.Data;
using GerenciadorDeTarefasComAutenticacaoAPI.Data.DTOs;
using GerenciadorDeTarefasComAutenticacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Controllers
{
    public class TaferaController
    {
        private TarefasDbContext _context;
        private IMapper _mapper;

        public TaferaController(IMapper mapper, TarefasDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpPost]
        public void AdicionarTarefa([FromBody] CreateTarefaDTO tarefaDTO)
        {
            Tarefa tarefa = _mapper.Map<Tarefa>(tarefaDTO);
            _context.Tarefa.Add(tarefa);
            _context.SaveChanges();
            //return CreatedAtAction(nameof(RetornaCinemasPorId), new { Id = categoria.Id }, categoriaDTO);
        }
        [HttpGet]
        public string RetornaTarefa()
        {
            return "teste ok";
        }
        [HttpGet("{id}")]
        public string RetornaTarefa(int id)
        {
            return id.ToString();
        }
    }
}
