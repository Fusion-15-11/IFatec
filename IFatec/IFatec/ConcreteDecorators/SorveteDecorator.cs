using IFatec.Factories;
using IFatec.Decorators;

namespace IFatec.Decorators
{
    public class SorveteDecorator : SobremesaDecorator
    {
        public SorveteDecorator(ISobremesa sobremesa) : base(sobremesa)
        {}
        public override string BuscarDescrição()
        {
            return base.BuscarDescrição() + "Sorvete";
        }
    }
}
