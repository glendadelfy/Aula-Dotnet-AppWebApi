using AppWebApi.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AppWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        [Route("Listar")]
        public IActionResult Get(int id)
        {
            var user = new UsuarioModel().MockList();
            if (user == null)

                return NotFound();

            return Ok(user);

        }
        [HttpPost]
        [Route("Adicionar")]
        public IActionResult Post([FromBody] UsuarioModel model) {
            {
                if (model == null)
                    return BadRequest();

                var user = new UsuarioModel()
                {
                    id = model.id,
                    nome = model.nome,
                    dataNascimento = model.dataNascimento,
                    endereco = model.endereco,
                    email = model.email,

                };
                return Ok(user);
            }

        }

        [HttpPut]
        [Route("Atualizar")]
        public IActionResult Put([FromBody] UsuarioModel model)
        {
            if (model == null)
                return BadRequest();
            var userResponse = new UsuarioModel().MockUpdate(model);
            if (userResponse.id == 0)
                return BadRequest();
            return Ok(userResponse);
        }

        [HttpDelete]
        [Route("Deletar")]
        public IActionResult Delete(long id)
        {
            if (id == 0)
                return BadRequest();
            return NoContent();
        }
    }

}
