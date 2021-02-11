namespace exercicio2
{
    public abstract class Transporte
    {
        public Carga carga;
        public Transporte(Carga param){
            this.carga = param;
        }
        public abstract double calculaFrete();
    }
}