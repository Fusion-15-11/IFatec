namespace IFatec.Interface
{
    public interface IDadoPedido /*Interface do Memento, onde é um contrato que a classe é obrigada a utilizar
                                   nesse caso, o Ticket é obrigado a implementar essas informações*/
    {
        string GetPratoPrincipal();
        string GetSobremesa();
        string GetBebida();
        DateTime GetData();
    }
}
