namespace exercicio2
{
    public class Vagao : Transporte
    {
        public Vagao(Carga param) : base(param){}

         public override double calculaFrete(){
            double frete = 0;          
            double peso = this.carga.getPeso();
            double valor = this.carga.getValor();

            frete += (peso * 0.2) + (valor * 0.1);
            if(peso < 15000){
                frete += 5000;
            }
            return frete;
        }
        
    }
}