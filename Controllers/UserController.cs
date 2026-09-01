using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Comunication.Requests;
using MyFirstApi.Comunication.Responses;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")] //atributo obrigatório para definir a rota do controller
[ApiController] //significa que é um controller de API, habilitando recursos como validação automática de modelo e respostas automáticas para erros de validação

public class UserController : ControllerBase
{
    [HttpGet] //isso é um endpoint que responde a requisições HTTP GET, significando que ele é usado para recuperar recursos do servidor
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Age = 20,
            Name = "John Doe"
        };

        return Ok(response);
    }
    
    
    [HttpPost] //isso é um endpoint que responde a requisições HTTP POST, significando que ele é usado para criar novos recursos no servidor
    [ProducesResponseType(typeof(ResponseRegisterUsersJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody]RequestRegisterUserJson request)
    {
        var response = new ResponseRegisterUsersJson
        {
            Id = 1,
            UserName = request.Name
        };

        return Created(string.Empty, response);
    }
}

