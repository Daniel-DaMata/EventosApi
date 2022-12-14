using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EventosApi.Models;

namespace EventosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BaladaExemploController : ControllerBase
    {
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            baladas.RemoveAll(bala => bala.Id == id);

            return Ok(baladas);
        }

        [HttpPut]
        public IActionResult UpdateBalada(Balada b)
        {
            Balada baladaAlterado = baladas.Find(bala => bala.Id == b.Id);
            baladaAlterado.Nome = b.Nome;
            baladaAlterado.Bebida = b.Bebida;
            baladaAlterado.Endereco = b.Endereco;
            baladaAlterado.Entrada = b.Entrada;

            return Ok(baladas);
        }

        [HttpGet("GetByNomeAproximado/{nome}")]
        public IActionResult GetByNomeAproximado(string nome)
        {
            List<Balada> listaBusca = baladas.FindAll(b => b.Nome.Contains(nome));
            return Ok(listaBusca);
        }

        [HttpGet("GetContagem")]
        public IActionResult GetQuantidade()
        {
            return Ok("Quantidade de baladas: " + baladas.Count);
        }

        [HttpPost]
        public IActionResult AddBalada(Balada novoBalada)
        {
            baladas.Add(novoBalada);
            return Ok(baladas);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(baladas.FirstOrDefault(ba => ba.Id == id));
        }

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Balada b = baladas[0];
            return Ok(b);
        }
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(baladas);
        }
        private static List<Balada> baladas = new List<Balada>()
        {
            new Balada() { Id = 1, Nome = "Start", Endereco = "Avenida JoaPaulo", Bebida = true, Entrada = 10 },
            new Balada() { Id = 2, Nome = "Red", Endereco = "Avenida Nova", Bebida = true, Entrada = 30 },
            new Balada() { Id = 3, Nome = "Lux", Endereco = "Avenida Engenheiro", Bebida = true, Entrada = 20 },
            new Balada() { Id = 4, Nome = "Barcelona", Endereco = "Avenida Nova", Bebida = true, Entrada = 10 },
            new Balada() { Id = 5, Nome = "Dubai", Endereco = "Avenida Cruzeiro", Bebida = true, Entrada = 60 },
            new Balada() { Id = 6, Nome = "Slim", Endereco = "Avenida Guilherme", Bebida = true, Entrada = 25 },
            new Balada() { Id = 1, Nome = "Robinho", Endereco = "Santana", Bebida = true, Entrada = 0 }
        };
    }
}