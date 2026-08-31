using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")] //atributo obrigatório para definir a rota do controller
[ApiController] //significa que é um controller de API, habilitando recursos como validação automática de modelo e respostas automáticas para erros de validação

public class UserController : ControllerBase
{
}
