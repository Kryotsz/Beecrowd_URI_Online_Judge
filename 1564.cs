using System;

namespace uri1564
{
    class Program
    {
        static void Main(string[] args)
        {
            string ValorEntrada;
            int N;

            while(true){
                ValorEntrada=Console.ReadLine();

                if(string.IsNullOrEmpty(ValorEntrada)){
                    break;
                }

                N=int.Parse(ValorEntrada);

                if(N==0){
                    Console.WriteLine("vai ter copa!");
                }else{
                    Console.WriteLine("vai ter duas!");
                } 
            }
        }
    }
}
