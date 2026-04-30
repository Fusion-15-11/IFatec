using IFatec.Factories;

namespace IFatec.Decorators.Bebida
{
    public class LimaoDecorator : BebidaDecorator
    {
            public LimaoDecorator(IBebida bebida) : base(bebida)
            {}
    
            public override string BuscarDescrição()
            {
                return base.BuscarDescrição() + " Com limão.";
        }
    }
}
