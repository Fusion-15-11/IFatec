using System;
using IFatec.Factories;
using IFatec.Decorators;

namespace IFatec.Decorators
{
    public class LimaoDecorator : BebidaDecorator
    {
            public LimaoDecorator(IBebida bebida) : base(bebida)
            {}
    
            public override string BuscarDescrição()
            {
                return base.BuscarDescrição() + " Limão";
        }
    }
}
