using System;

namespace uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, valor;

            N=int.Parse(Console.ReadLine());

            for(int i=1;i<=N;i++){
                valor=int.Parse(Console.ReadLine());
                if(valor==0){
                    Console.WriteLine("NULL");
                }else{
                    if(valor%2==0){
                        if(valor>0){
                            Console.WriteLine("EVEN POSITIVE");
                        }else{
                            Console.WriteLine("EVEN NEGATIVE");
                        }
                    }else if(valor>0){
                        Console.WriteLine("ODD POSITIVE");
                    }else{
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}
