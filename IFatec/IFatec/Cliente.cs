using IFatec.Factories;

namespace IFatec
{
    public class Cliente
    {
        IBebida bebida;
        IPratoPrincipal pratoPrincipal;
        ISobremesa sobremesa;

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

    }
}
