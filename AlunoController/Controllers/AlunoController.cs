using AlunoController.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlunoController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateAluno([FromBody] Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            

            return Ok("Aluno criado com sucesso!");
        }
    }

}
