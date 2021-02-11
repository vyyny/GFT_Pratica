using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carga carga1 = new Carga(); 
            carga1.setPeso(18550);
            carga1.setValor(27500);
            Carga carga2 = new Carga(); 
            carga2.setPeso(18550);
            carga2.setValor(27500);
            Carga carga3 = new Carga(); 
            carga3.setPeso(18550);
            carga3.setValor(27500);
            Carga carga4 = new Carga(); 
            carga4.setPeso(18550);
            carga4.setValor(27500);
            Carga carga5 = new Carga(); 
            carga5.setPeso(18550);
            carga5.setValor(27500);
            Carga carga6 = new Carga(); 
            carga6.setPeso(18550);
            carga6.setValor(27500);
            Carga carga7 = new Carga(); 
            carga7.setPeso(18550);
            carga7.setValor(27500);

            SimulacaoCustoFrete simulacao = new SimulacaoCustoFrete();

            simulacao.simular(carga1, carga2, carga3, carga4, carga5, carga6, carga7);

            
            
            
        }
    }
}
