using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    [HttpPost]
    public IActionResult CriarProduto([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
        {
            var erros = ModelState.Values
                                   .SelectMany(v => v.Errors)
                                   .Select(e => e.ErrorMessage)
                                   .ToList();
            return BadRequest(erros);
        }

        return CreatedAtAction(nameof(CriarProduto), new { id = 1 }, produto); 
    }

}
