namespace IFatec.Class;

using IFatec.Interface;

class Ticket : IDadoPedido /**/
{
    private string PratoPrincipal;
    private string Sobremesa;
    private string Bebida;
    private DateTime Data;

    /*Aqui colocamos as informações recebidas dentro do memento onde não poderá ser mudado
     ou seja, imutável*/
    public Ticket(string pratoPrincipal, string sobremesa, string bebida, DateTime data_hora)
    {
        this.PratoPrincipal = pratoPrincipal;
        this.Sobremesa = sobremesa;
        this.Bebida = bebida;
        this.Data = data_hora;
    }

    public string GetPratoPrincipal()
    {
        return this.PratoPrincipal;
    }
    public string GetSobremesa()
    {
        return this.Sobremesa;
    }

    public string GetBebida()
    {
        return this.Bebida;
    }

    public DateTime GetData()
    {
        return this.Data;
    }
}
