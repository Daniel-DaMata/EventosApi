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
    public class BaladasController : ControllerBase
    {
        private readonly DataContext _context;

        public BaladasController(DataContext context)
        {

            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Balada> lista = await _context.baladas.ToListAsync();
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
                Balada b = await _context.baladas
                    .FirstOrDefaultAsync(bBusca => bBusca.Id == id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
        //o metodo apresenta algum erro, por isso esta comentado

        [HttpPost]
        public async Task<IActionResult> Add(Balada novoBalada)
        {
            try
            {
                await _context.baladas.AddAsync(novoBalada);
                await _context.SaveChangesAsync();

                return Ok(novoBalada.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Balada novoBalada)
        {
            try
            {
                _context.baladas.Update(novoBalada);
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
                Balada bRemover = await _context.baladas
                    .FirstOrDefaultAsync(b => b.Id == id);

                _context.baladas.Remove(bRemover);
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