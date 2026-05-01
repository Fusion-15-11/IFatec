using System;
using IFatec.Factories;

namespace IFatec.Decorators
{
    public  abstract class SobremesaDecorator : ISobremesa
    {
        protected ISobremesa _sobremesa;
        public SobremesaDecorator(ISobremesa sobremesa)
        {
            _sobremesa = sobremesa;
        }
        public virtual string BuscarDescrição()
        {
            return _sobremesa.BuscarDescrição();
        }
    }
}
