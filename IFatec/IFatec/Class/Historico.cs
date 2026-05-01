namespace IFatec.Class;

using IFatec.Interface;
class Historico //Caretaker
{
    private List<IDadoPedido> dadopedido = new List<IDadoPedido>(); //Lista de Dados do Pedido

    private Pedido pedido = null;

    public Historico(Pedido _pedido)
    {
        this.pedido = _pedido;
    }

    public void Backup()
    {
        Console.WriteLine("Histórico: Salvando Pedido...");
        this.dadopedido.Add(this.pedido.Save());
    }

    public void Desfazer()
    {
        if (this.dadopedido.Count == 0)
        {
            return;
        }

        var _dadopedido = this.dadopedido.Last();
        this.dadopedido.Remove(_dadopedido);

        Console.WriteLine("Histórico: Restaurando Para: " + _dadopedido.GetPratoPrincipal());

        try
        {
            this.pedido.Restore(_dadopedido);
        }
        catch (Exception)
        {
            this.Desfazer();
        }
    }

    public void MostrarHistorico()
    {
        Console.WriteLine("Histórico: Aqui está a lista de Pedidos:");

        foreach (var _dadopedido in this.dadopedido)
        {
            Console.WriteLine(_dadopedido.GetPratoPrincipal());
        }
    }
}
