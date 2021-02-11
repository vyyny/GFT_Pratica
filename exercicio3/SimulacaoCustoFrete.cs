using System;

namespace exercicio3
{
    public class SimulacaoCustoFrete
    {
        public void simular(Carga carga1, Carga carga2, Carga carga3, Carga carga4, Carga carga5, Carga carga6, Carga carga7){
           double vagao;
           double caminhao;
           double caminhaoQt = 0;
           double vagaoQt = 0;
           double custo = 0;

            Transporte caminhao1 = new Caminhao(carga1);
            Transporte vagao1 = new Vagao(carga1);
            vagao = vagao1.calculaFrete();
            caminhao = caminhao1.calculaFrete();
            if(vagao < caminhao){
                vagaoQt++;
                custo += vagao;
            }else{
                caminhaoQt++;
                custo += caminhao;
            }
            Transporte caminhao2 = new Caminhao(carga2);
            Transporte vagao2 = new Vagao(carga2);
            vagao = vagao2.calculaFrete();
            caminhao = caminhao2.calculaFrete();
            if(vagao < caminhao){
                vagaoQt++;
                custo += vagao;
            }else{
                caminhaoQt++;
                custo += caminhao;
            }
            Transporte caminhao3 = new Caminhao(carga3);
            Transporte vagao3 = new Vagao(carga3);
            vagao = vagao3.calculaFrete();
            caminhao = caminhao3.calculaFrete();
            if(vagao < caminhao){
                vagaoQt++;
                custo += vagao;
            }else{
                caminhaoQt++;
                custo += caminhao;
            }
            Transporte caminhao4 = new Caminhao(carga4);
            Transporte vagao4 = new Vagao(carga4);
            vagao = vagao4.calculaFrete();
            caminhao = caminhao4.calculaFrete();
            if(vagao < caminhao){
                vagaoQt++;
                custo += vagao;
            }else{
                caminhaoQt++;
                custo += caminhao;
            }
            Transporte caminhao5 = new Caminhao(carga5);
            Transporte vagao5 = new Vagao(carga5);
            vagao = vagao5.calculaFrete();
            caminhao = caminhao5.calculaFrete();
            if(vagao < caminhao){
                vagaoQt++;
                custo += vagao;
            }else{
                caminhaoQt++;
                custo += caminhao;
            }
            Transporte caminhao6 = new Caminhao(carga6);
            Transporte vagao6 = new Vagao(carga6);
            vagao = vagao6.calculaFrete();
            caminhao = caminhao6.calculaFrete();
            if(vagao < caminhao){
                vagaoQt++;
                custo += vagao;
            }else{
                caminhaoQt++;
                custo += caminhao;
            }
            Transporte caminhao7 = new Caminhao(carga7);
            Transporte vagao7 = new Vagao(carga7);
            vagao = vagao7.calculaFrete();
            caminhao = caminhao7.calculaFrete();
            if(vagao < caminhao){
                vagaoQt++;
                custo += vagao;
            }else{
                caminhaoQt++;
                custo += caminhao;
            }

            Console.WriteLine("numero de caminhoes");
            Console.WriteLine(caminhaoQt);
            Console.WriteLine("numero de vagoes");
            Console.WriteLine(vagaoQt);
            Console.WriteLine("custo");
            Console.WriteLine(custo);
        }
    }
}