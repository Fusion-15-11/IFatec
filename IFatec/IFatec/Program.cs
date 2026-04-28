using IFatec;
using IFatec.Factories;

IIFatecFactory factory;

factory = new FactoryItaliana();
{
    var cliente = new Cliente(factory);
    cliente.CriarPedido();
}

factory = new FactoryJaponesa();
{
    var cliente = new Cliente(factory);
    cliente.CriarPedido();
}