using System;
using IFatec.Factories;

namespace IFatec.Decorators
{
    public  abstract class BebidaDecorator : IBebida
    {
        protected IBebida _bebida;
        public BebidaDecorator(IBebida bebida)
        {
            _bebida = bebida;
        }
        public virtual string BuscarDescricao()
        {
            return _bebida.BuscarDescricao();
        }
    }
}
