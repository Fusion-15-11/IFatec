using System;
using IFatec.Factories;
using IFatec.Decorators;

namespace IFatec.Decorators
{
    public class GeloDecorator : BebidaDecorator
    {
        public GeloDecorator(IBebida bebida) : base(bebida)
        {}

        public override string BuscarDescrição()
        {
            return base.BuscarDescrição() + " Gelo";
        }
    }
}
