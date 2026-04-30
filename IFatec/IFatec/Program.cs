/*using IFatec;
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

*/

using IFatec;
using IFatec.Factories;

IIFatecFactory pedidoItaliano = new FactoryItaliana();
Cliente cliente = new Cliente(pedidoItaliano);

// AQUI entra o decorator
cliente.AdicionarGelo();
cliente.AdicionarLimao();

Console.WriteLine(cliente.BuscarDescricaoBebida());


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

// ESTA LINHA ABAIXO resolve o erro 404 na página inicial:
app.MapGet("/", context => {
    context.Response.Redirect("/Index");
    return Task.CompletedTask;
});

app.Run();