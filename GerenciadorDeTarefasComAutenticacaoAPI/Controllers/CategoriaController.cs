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
        public void AdicionarCategoria([FromBody] CreateCategoriaDTO categoriaDTO)
        {
            Categoria categoria = _mapper.Map<Categoria>(categoriaDTO);
            _context.Cinemas.Add(categoria);
            _context.SaveChanges();
            //return CreatedAtAction(nameof(RetornaCinemasPorId), new { Id = categoria.Id }, categoriaDTO);
        }
        [HttpGet]
        public string RetornaCategorias()
        {
            return "teste ok";
        }
        [HttpGet("{id}")]
        public string RetornaCategoria(int id) 
        {
            return id.ToString();
        }
    }
}
