using Microsoft.AspNetCore.Mvc;
using EventosApi.Data;
using System.Threading.Tasks;
using EventosApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {

            _context = context;
        }

         [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Evento> lista = await _context.eventos.ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       /* [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Evento e = await _context.eventos
                    .FirstOrDefaultAsync(eBusca => eBusca.Id == id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
        //o metodo apresenta algum erro, por isso esta comentado

        [HttpPost]
        public async Task<IActionResult> Add(Evento novoEvento)
        {
            try
            {
                await _context.eventos.AddAsync(novoEvento);
                await _context.SaveChangesAsync();

                return Ok(novoEvento.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Evento novoEvento)
        {
            try
            {
                _context.eventos.Update(novoEvento);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Evento eRemover = await _context.eventos
                    .FirstOrDefaultAsync(e => e.Id == id);

                _context.eventos.Remove(eRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}