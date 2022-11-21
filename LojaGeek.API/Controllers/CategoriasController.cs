using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaGeek.API.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace LojaGeek.API.Controllers
{
    [Route("api/[Controller]")]
    public class CategoriasController: ControllerBase
    {        
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost("{id}")]

        public IActionResult Post([FromBody] CreateCategoriaInputModel inputModel)
        {
            return CreatedAtAction(nameof(Get), new { id = 10 }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateCategoriaInputModel inputModel)
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
