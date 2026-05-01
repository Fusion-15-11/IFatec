namespace IFatec.Class;

using IFatec.Interface;


    //Memento

    class Pedido /* Originator: Seria o objeto mãe, nesse caso, o PEDIDO, que armazenaria o Prato Principal, 
             Sobremesa e Bebida do Cliente onde ele pode ter os métodos Salvar(um novo pedido com os pratos) 
             e Restaurar (objeto que já foi usado anteriormente) */
{
    //Declaração das varáveis
    private string PratoPrincipal;
    private string Sobremesa;
    private string Bebida;
    private DateTime Data;

    public Pedido(string pratoPrincipal, string sobremesa, string bebida, DateTime data_hora)
    {
        //Traz os dados vindos do pedido que o cliente fez
        this.PratoPrincipal = pratoPrincipal;
        this.Sobremesa = sobremesa;
        this.Bebida = bebida;
        this.Data = data_hora;

        Console.WriteLine("Pedido:\n\n" + PratoPrincipal + Sobremesa + Bebida + Data);
    }

    public IDadoPedido Save() //Salva esses dados em um memento, no caso o Ticket
    {
        return new Ticket(PratoPrincipal, Sobremesa, Bebida, Data);
    }

    public void Restore(IDadoPedido dadopedido)
    /*O método restore, está restaurando um objeto que já foi utilizado */
    {
        //Verifica se o dadopedido, é do tipo ticket, ou seja, com as mesmas variáveis
        if (!(dadopedido is Ticket))
        {
            throw new Exception("Pedido Desconhecido: " + dadopedido.ToString());
        }
        this.PratoPrincipal = dadopedido.GetPratoPrincipal();
        this.Sobremesa = dadopedido.GetSobremesa();
        this.Bebida = dadopedido.GetBebida();
        this.Data = dadopedido.GetData();
        Console.Write($"Pedido Mudou Para:\n\n Prato Principal: {PratoPrincipal}\n Sobremesa: {Sobremesa}\n Bebida: {Bebida}");
    }
}
