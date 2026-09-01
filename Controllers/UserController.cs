using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Comunication.Requests;
using MyFirstApi.Comunication.Responses;

namespace MyFirstApi.Controllers;

public class UserController : MyFirstApiBaseController //isso é herança porque a classe UserController está herdando da classe MyFirstApiBaseController
                                                       //o que significa que ela pode acessar os métodos e propriedades da classe base, além de poder sobrescrever ou adicionar novos comportamentos específicos para a classe derivada.
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

    [HttpPut]//isso é um endpoint que responde a requisições HTTP PUT, significando que ele é usado para atualizar recursos existentes no servidor
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody]RequestUpdateUserProfileJson request)// isso é um public de Update que significa que ele é usado para atualizar recursos existentes no servidor
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
   //get e delet nao recebe requisição no body
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll(int id)
    {
        var response = new List<User>()
        {
            new User {Id = 1, Age = 10, Name = "Antony"},
            new User {Id = 2, Age = 20, Name = "Selena"},
        };

        var key = GetCustomKey();
        return Ok(key);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }

}


