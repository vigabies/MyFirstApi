using System.Reflection.Metadata.Ecma335;

namespace MyFirstApi.Entities;

public sealed class Laptop : Device // nome:nome significa herança, sealed significa que a classe não pode ser herdada por outras classes, ou seja, é uma classe final.
{
    public override string GetBrand() //override significa que estamos sobrescrevendo o método da classe base, fornecendo uma implementação específica para a classe derivada.
    {

        return "Apple";
    }

    public override string GetTest()
    {
        return "test laptop";
    }

    public string GetModel()
    {
        var isConnected = IsConnected(); //chamando o método da classe base
        if (isConnected) return "Macbook Pro";

        return "Unknow";
    }
}
