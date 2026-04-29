using IFatec;
using IFatec.Factories;

namespace IFatec
{
    class Program
    {
        static void Main(string[] args)
        {
            IIFatecFactory pedidoItaliano = new FactoryItaliana();
            Cliente italianoCliente = new Cliente(pedidoItaliano);

            Console.WriteLine("**PEDIDO ITALIANO**");
            Console.WriteLine(italianoCliente.BuscarDescricaoPratoPrincipal());
            Console.WriteLine(italianoCliente.BuscarDescricaoSobremesa());
            Console.WriteLine(italianoCliente.BuscarDescricaoBebida());

            IIFatecFactory pedidoJapones = new FactoryJaponesa();
            Cliente japonesCliente = new Cliente(pedidoJapones);

            Console.WriteLine("**PEDIDO JAPONES**");
            Console.WriteLine(japonesCliente.BuscarDescricaoPratoPrincipal());
            Console.WriteLine(japonesCliente.BuscarDescricaoSobremesa());
            Console.WriteLine(japonesCliente.BuscarDescricaoBebida());

            Console.ReadKey();



        }
    }
}