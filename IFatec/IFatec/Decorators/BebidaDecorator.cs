using IFatec.Factories;

namespace IFatec.Decorators.Bebida
{
    public  abstract class BebidaDecorator : IBebida
    {
        protected IBebida _bebida;
        public BebidaDecorator(IBebida bebida)
        {
            _bebida = bebida;
        }
        public virtual string BuscarDescrição()
        {
            return _bebida.BuscarDescrição();
        }
    }
}
