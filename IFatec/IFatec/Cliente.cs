using IFatec.Factories;

namespace IFatec
{
    public class Cliente
    {
        IBebida bebida;
        IPratoPrincipal pratoPrincipal;
        ISobremesa sobremesa;

        public void PersonalizarPrato(string ingrediente)
        {
            if (!string.IsNullOrWhiteSpace(ingrediente))
            {
                pratoPrincipal.RetirarIngrediente(ingrediente);
            }
        }

        public Cliente(IIFatecFactory ifatec) 
        {
            bebida = ifatec.BuscarBebida();
            pratoPrincipal = ifatec.BuscarPratoPrincipal();
            sobremesa = ifatec.BuscarSobremesa();  
        }

        public string BuscarDescricaoBebida()
        {
            return bebida.BuscarDescrição();
        }

        public string BuscarDescricaoPratoPrincipal()
        {
            return pratoPrincipal.BuscarDescrição();
        }

        public string BuscarDescricaoSobremesa()
        {
            return sobremesa.BuscarDescrição();
        }

        public void AdicionarGelo()
        {
            bebida = new Decorators.Bebida.GeloDecorator(bebida);
        }

        public void AdicionarLimao()
        {
            bebida = new Decorators.Bebida.LimaoDecorator(bebida);
        }


    }
}
