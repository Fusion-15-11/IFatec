namespace IFatec.Class.Pedido;
using IFatec.Interface;
using System;

// Originator - Pedido no seu estado atual, com os adicionais
class Pedido
{
    //Declara as varáveis
    private string PratoPrincipal;
    private string Sobremesa;
    private string Bebida;
    private DateTime Data;

    public Pedido(string pratoPrincipal, string sobremesa, string bebida, DateTime data_hora)
    {
        //Recebe dentro do pedido, os parâmetros que o cliente adicionou em seus pratos
        this.PratoPrincipal = pratoPrincipal;
        this.Sobremesa = sobremesa;
        this.Bebida = bebida;
        this.Data = data_hora;
    }

    public Ticket Save()
    {
        // Cria o (Ticket) com os dados atuais
        return new Ticket(this.PratoPrincipal, this.Sobremesa, this.Bebida, this.Data);
    }

    //Trata para ver se o Ticket está de acordo com a interface DadoPedido
    public void Restore(IDadoPedido dadopedido)
    {
        if (!(dadopedido is Ticket ticket))
        {
            throw new Exception("Tipo de Ticket inválido.");
        }

        // Restaura os campos internos a partir do Ticket
        this.PratoPrincipal = ticket.GetPratoPrincipal();
        this.Sobremesa = ticket.GetSobremesa();
        this.Bebida = ticket.GetBebida();
        this.Data = ticket.GetData();
    }

    public string GetPratoPrincipal() => this.PratoPrincipal;
    public string GetSobremesa() => this.Sobremesa;
    public string GetBebida() => this.Bebida;
}