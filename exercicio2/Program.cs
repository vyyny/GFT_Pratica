using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique o peso:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Indique o valor:");
            double valor = double.Parse(Console.ReadLine());

            Carga carga = new Carga(); 
            carga.setPeso(peso);
            carga.setValor(valor);

            Transporte caminhao = new Caminhao(carga);
            Transporte vagao = new Vagao(carga);
            Console.WriteLine("caminha:");
            Console.WriteLine(caminhao.calculaFrete());
            Console.WriteLine("vagao:");
            Console.WriteLine(vagao.calculaFrete());
            
        }
    }
}
