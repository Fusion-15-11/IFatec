using System.Collections.Generic;
using System.Linq;
using IFatec.Interface;

namespace IFatec.Class.Pedido;

//Caretaker - Onde são armazenados os tickets (mementos) realizados em formato de pilha
class Historico
{
    //Declaração das Variáveis
    private Stack<IDadoPedido> _dadopedido = new Stack<IDadoPedido>();
    private Pedido _pedido;

    public Historico(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void Backup()
    {
        // Salva o estado atual no topo da pilha
        _dadopedido.Push(_pedido.Save());
    }

    public void Desfazer()
    {
        if (_dadopedido.Count <= 1)
        {
            Console.WriteLine("Histórico: Não há estados anteriores para restaurar.");
            return;
        }

        // Remove o estado atual
        _dadopedido.Pop();

        //Olha o estado anterior sem removê-lo
        var ticketAnt = _dadopedido.Peek();

        try
        {
            Console.WriteLine("Histórico: Restaurando para o estado anterior...");
            _pedido.Restore(ticketAnt);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao restaurar: {ex.Message}");
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
    public List<IDadoPedido> GetHistorico()
    {
        return this.dadopedido;
    }

    public void SetPedido(Pedido novoPedido)
    {
        this.pedido = novoPedido;
    }
}
=======
    // Conversão para lista para o INDEX
    public List<IDadoPedido> GetHistorico() => _dadopedido.ToList();
}
>>>>>>> Erick
=======
    // Conversão para lista para o INDEX
    public List<IDadoPedido> GetHistorico() => _dadopedido.ToList();
}
>>>>>>> Erick
