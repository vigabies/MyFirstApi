using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")] //isso é uma rota que define o caminho base para os endpoints do controlador, permitindo que as requisições sejam direcionadas corretamente para os métodos correspondentes
[ApiController] //isso é um atributo que indica que a classe é um controlador de API, habilitando recursos como validação automática de modelo e formatação de resposta

//essa controller que fizemos será nossa referencia
//entao todas as outras controllers que criarmos irão herdar dela, assim conseguimos centralizar algumas funcionalidades e comportamentos comuns a todos os controladores da API:
//como autenticação, autorização, tratamento de erros, logging, entre outros.
public class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Oscar Wilde";
}
