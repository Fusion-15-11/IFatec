using System;
using IFatec.Decorators;
using IFatec.Factories;

namespace IFatec.Decorators
{
    public class ExtraQueijoParmesaoDecorator : AdicionalDecorator
    {
        // O construtor pega o prato e manda para a classe pai (base) guardar
        public ExtraQueijoParmesaoDecorator(IPratoPrincipal prato) : base(prato)
        {
        }

        // Sobrescrevemos a descrição para adicionar o texto do queijo
        public override string BuscarDescrição()
        {
            return base.BuscarDescrição() + " + Queijo Parmesão Extra";
        }
    }
}