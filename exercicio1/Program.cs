using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o multiplicando");
            int multiplicando = int.Parse(Console.ReadLine());
            if(multiplicando < 0 || multiplicando > 3000){
                Console.WriteLine("Multiplicando invalido");
                return;
            }

            Console.WriteLine("digite o valor inicial");
            int inicio = int.Parse(Console.ReadLine());
            if(inicio < 0 || inicio > 3000){
                Console.WriteLine("valor inicial invalido");
                return;
            }

            Console.WriteLine("digite o valor final");
            int fim = int.Parse(Console.ReadLine());
            if(fim < 0 || fim > 3000){
                Console.WriteLine("valor final invalido");
                return;
            }

            if((fim - inicio) >= 10){
                Console.WriteLine("A diferença de inicio e fim excede 10");
                return;
            }

            if((fim - inicio) < 0){
                Console.WriteLine("Valor final deve ser menor que o inicial");
                return;
            }

            for(int i = inicio; i<=fim; i++){
                Console.WriteLine(multiplicando + " X " + i + " = " + (i*multiplicando));
            }

            Console.WriteLine("FIM");
        }
    }
}
