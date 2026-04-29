using IFatec.Factories;

namespace IFatec.Products.Italiana
{
    //Produto Concreto
    public class Lasanha : IPratoPrincipal
    {
        public string BuscarDescrição()
        {
            return "LASANHA:\n Massa de ovos, molho bolonhesa rico em sabor, bechamel cremoso e muçarela. Gratinada com parmesão ralado na hora.\n";
        }
    }
}
