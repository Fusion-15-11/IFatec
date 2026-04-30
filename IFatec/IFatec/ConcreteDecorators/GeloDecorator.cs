using IFatec.Factories;

namespace IFatec.Decorators.Bebida
{
    public class GeloDecorator : BebidaDecorator
    {
        public GeloDecorator(IBebida bebida) : base(bebida)
        {}

        public override string BuscarDescrição()
        {
            return base.BuscarDescrição() + " Com gelo.";
        }
    }
}
