namespace IFatec.Class.Pedido;
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

        
        try
        {
            Console.WriteLine("Histórico: Restaurando Para: " + _dadopedido.GetPratoPrincipal());
            this.pedido.Restore(_dadopedido);
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao restaurar snapshot: {ex.Message}");
        }
    }

    public List<IDadoPedido> GetHistorico()
    {
        return this.dadopedido;
    }
}
