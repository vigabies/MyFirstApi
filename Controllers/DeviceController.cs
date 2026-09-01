using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

//Fazemos controller em uma api, porque é uma forma de organizar o código e separar as responsabilidades, tornando o código mais legível e fácil de manter.
//Além disso, os controllers permitem que você defina rotas específicas para cada recurso da API, facilitando a navegação e o acesso aos dados.

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Author);
    }
}
