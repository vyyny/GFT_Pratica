namespace exercicio2
{
    public class Caminhao : Transporte
    {
        public Caminhao(Carga param) : base(param){}

         public override double calculaFrete(){
            double frete = 0;          
            double peso = this.carga.getPeso();
            double valor = this.carga.getValor();

            frete += (peso * 0.12) + (valor * 0.3);
            if(valor > 40000){
                frete -= frete * 0.25;
            }
            return frete;
        }
        
    }
}