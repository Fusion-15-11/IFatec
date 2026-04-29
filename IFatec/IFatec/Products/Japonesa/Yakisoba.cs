using IFatec.Factories;

namespace IFatec.Products.Japonesa
{
    //Produto Concreto

    public class Yakisoba : IPratoPrincipal
    {
        public string BuscarDescrição()
        {
            return "YAKISOBA:\n Macarrão selado na chapa com mix de legumes frescos, carnes [bovina e frango] e molho à base de shoyu e especiarias orientais.\n";
        }
    }
}
