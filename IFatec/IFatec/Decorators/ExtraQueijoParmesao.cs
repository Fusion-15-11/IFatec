using System;
using IFatec.Factories;

namespace IFatec.Decorators
{
    public class ExtraQueijoParmesao : AdicionalDecorator
    {
        // O construtor pega o prato e manda para a classe pai (base) guardar
        public ExtraQueijoParmesao(IPratoPrincipal prato) : base(prato)
        {
        }

        // Sobrescrevemos a descrição para adicionar o texto do queijo
        public override string BuscarDescrição()
        {
            return base.BuscarDescrição() + " + Queijo Parmesão Extra";
        }
    }
}