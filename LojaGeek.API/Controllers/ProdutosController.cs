using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaGeek.API.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace LojaGeek.API.Controllers
{
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost("{id}")]

        public IActionResult Post([FromBody]CreateProdutoInputModel inputModel)
        {
            return CreatedAtAction(nameof(Get), new { id = 10 }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult put(int id, [FromBody] UpdateProdutoInputModel inputModel)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] UpdateCategoriaInputModel inputModel)
        {
            return NoContent();
        }




    }
}
