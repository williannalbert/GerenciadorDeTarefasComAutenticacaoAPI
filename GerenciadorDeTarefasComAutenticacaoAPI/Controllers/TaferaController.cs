using AutoMapper;
using GerenciadorDeTarefasComAutenticacaoAPI.Data;
using GerenciadorDeTarefasComAutenticacaoAPI.Data.DTOs;
using GerenciadorDeTarefasComAutenticacaoAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TaferaController : ControllerBase
    {
        private TarefasDbContext _context;
        private IMapper _mapper;

        public TaferaController(IMapper mapper, TarefasDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionarTarefa([FromBody] CreateTarefaDTO tarefaDTO)
        {

            Categoria categoria = _context.Categoria.FirstOrDefault(categoria => categoria.Id == tarefaDTO.CategoriaId);
            if(categoria == null)
                return NotFound();

            Tarefa tarefa = _mapper.Map<Tarefa>(tarefaDTO);
            _context.Tarefa.Add(tarefa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RetornaTarefa), new { Id = tarefa.Id }, tarefaDTO);
        }
        [HttpGet]
        public IEnumerable<ReadTarefaDTO> RetornaTarefa([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadTarefaDTO>>(_context.Tarefa
                .Skip(skip)
                .Take(take)
                .ToList());
        }
        [HttpGet("{id}")]
        public IActionResult RetornaTarefa(int id)
        {
            Tarefa tarefa = _context.Tarefa.FirstOrDefault(tarefa => tarefa.Id == id);
            if(tarefa == null)
                return NotFound();

            ReadTarefaDTO readTarefaDTO = _mapper.Map<ReadTarefaDTO>(tarefa);
            return Ok(readTarefaDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarTarefa(int id)
        {
            Tarefa tarefa = _context.Tarefa.FirstOrDefault(tarefa => tarefa.Id == id);
            if (tarefa == null)
                return NotFound();

            _context.Remove(tarefa);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
