using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")] //atributo obrigatório para definir a rota do controller
[ApiController] //significa que é um controller de API, habilitando recursos como validação automática de modelo e respostas automáticas para erros de validação

public class UserController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get([FromHeader] int id, [FromHeader]  string nickname)
    {
        var response = new User
        {
            Id = 1,
            Age = 20,
            Name = "John Doe"
        };

        return Ok(response);
    }
}
