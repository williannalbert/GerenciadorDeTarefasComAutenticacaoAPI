using AutoMapper;
using GerenciadorDeTarefasComAutenticacaoAPI.Data;
using GerenciadorDeTarefasComAutenticacaoAPI.Data.DTOs;
using GerenciadorDeTarefasComAutenticacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private TarefasDbContext _context;
        private IMapper _mapper;

        public CategoriaController(IMapper mapper, TarefasDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionarCategoria([FromBody] CreateCategoriaDTO categoriaDTO)
        {
            Categoria categoria = _mapper.Map<Categoria>(categoriaDTO);
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RetornaCategoria), new { Id = categoria.Id }, categoriaDTO);
        }
        [HttpGet]
        public IEnumerable<ReadCategoriaDTO> RetornaCategorias([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadCategoriaDTO>>(_context.Categoria
                .Skip(skip)
                .Take(take)
                .ToList());
        }
        [HttpGet("{id}")]
        public IActionResult RetornaCategoria(int id) 
        {
            Categoria categoria = _context.Categoria.FirstOrDefault(categoria => categoria.Id == id);
            if(categoria == null)
                return NotFound();

            ReadCategoriaDTO readCategoriaDTO = _mapper.Map<ReadCategoriaDTO>(categoria);

            return Ok(readCategoriaDTO);
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarCategoriaPut(int id, [FromBody] UpdateCategoriaDTO categoriaDTO)
        {
            Categoria categoria = _context.Categoria.FirstOrDefault(filme => filme.Id == id);
            if (categoria == null) return NotFound();

            _mapper.Map(categoriaDTO, categoria);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarCategoria(int id)
        {
            Categoria categoria = _context.Categoria.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null) return NotFound();

            _context.Remove(categoria);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
