namespace MyFirstApi.Entities;

// Ao colocar a palavra abstract antes da declaração de uma classe, estamos impedindo a criação de instâncias dessa classe.
// Apenas as classes derivadas podem ser instanciadas. Além disso, podemos usar o abstract em funções e propriedades, o que obriga as classes filhas a implementarem esses membros.
// Isso significa que as classes filhas devem fornecer uma implementação para essas funções ou propriedades abstratas.

public class Smartphone : Device
{
    public override string GetBrand()
    {
        return "Apple";    
    }
}
