using IFatec.Factories;

namespace IFatec.Products.Japonesa
{
    //Produto Concreto

    public class Saque : IBebida
    {
        public string BuscarDescricao()
        {
            return "Sake:\n Bebida fermentada de arroz polido, com aroma suave e teor alcoólico balanceado. Pode ser apreciado quente ou gelado. Adicional: \n";
        }
    }
}
