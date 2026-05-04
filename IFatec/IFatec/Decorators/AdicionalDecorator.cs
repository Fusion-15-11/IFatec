using System;
using IFatec.Factories; // Necessário para enxergar o IPratoPrincipal

namespace IFatec.Decorators
{
    public abstract class AdicionalDecorator : IPratoPrincipal
    {
        // Variável protegida que guarda o prato original
        protected IPratoPrincipal _pratoEnvolvido;

        // O construtor obriga a passar um prato existente na hora de criar o decorator
        public AdicionalDecorator(IPratoPrincipal prato)
        {
            _pratoEnvolvido = prato;
        }

        // Repassa a busca da descrição para o prato original
        public virtual string BuscarDescricao()
        {
            return _pratoEnvolvido.BuscarDescricao();
        }

        // Repassa a ordem de retirar ingrediente para o prato original
        public virtual void RetirarIngrediente(string ingrediente)
        {
            _pratoEnvolvido.RetirarIngrediente(ingrediente);
        }
    }
}