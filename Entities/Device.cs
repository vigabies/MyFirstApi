namespace MyFirstApi.Entities;

//classe base
public abstract class Device //abstract signfica que a classe não pode ser instanciada diretamente, mas pode ser herdada por outras classes.
                             //enquanto o abstract vai bloquear a instanciação da classe, o protected vai bloquear o acesso a um método ou propriedade de fora da classe
                             //mas ainda permite que classes derivadas acessem esses membros.
{
    protected bool IsConnected() => true;

    public abstract string GetBrand(); // na função abstract não é necessário implementar o corpo do método, apenas a assinatura.
                                       // a classes derivadas são obrigadas a implementar esse método.


    public virtual string GetTest() //virtual significa que o método pode ser sobrescrito em classes derivadas, mas não é obrigatório.
    {
        return "test";
    }
}
