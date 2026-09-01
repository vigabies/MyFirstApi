using System.Reflection.Metadata.Ecma335;

namespace MyFirstApi.Entities;

public class Laptop : Device //herança  
{
    public string GetModel()
    {
        var isConnected = IsConnected(); //chamando o método da classe base
        if (isConnected) return "Macbook Pro";

        return "Unknow";
    } 
}
