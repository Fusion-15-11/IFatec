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
        public virtual string BuscarDescricao()
        {
            return _sobremesa.BuscarDescricao();
        }
    }
}
