using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;

//Fazemos controller em uma api, porque é uma forma de organizar o código e separar as responsabilidades, tornando o código mais legível e fácil de manter.
//Além disso, os controllers permitem que você defina rotas específicas para cada recurso da API, facilitando a navegação e o acesso aos dados.

//uma função/propriedade quando é protected significa que ela só pode ser acessada dentro da própria classe ou em classes derivadas (herança).
//Ou seja, outras classes que não herdam da classe base não podem acessar membros protegidos.

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var laptop = new Laptop();

        var test = laptop.GetTest();  

        var model = laptop.GetModel();

        return Ok(model);

    }
}
