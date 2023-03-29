using System;
using System.Globalization;

namespace uri1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor=new string[2];
            double X, Y;

            vetor=Console.ReadLine().Split(' ');
            X=double.Parse(vetor[0],CultureInfo.InvariantCulture);
            Y=double.Parse(vetor[1],CultureInfo.InvariantCulture);

            if(X==0.0&&Y==0.0){
                Console.WriteLine("Origem");
            }else{
                if(X==0.0&&Y!=0.0){
                Console.WriteLine("Eixo X");
            }else{
                if(Y==0.0&&X!=0.0){
                Console.WriteLine("Eixo Y");
            }else{
                if(X>0.0){
                    if(Y>0.0){
                        Console.WriteLine("Q1");
                }else{
                    Console.WriteLine("Q4");
                }
            }else{
                if(Y>0.0){
                    Console.WriteLine("Q2");
                }else{
                    Console.WriteLine("Q3");
                }
            }
            }
            }
            }
        }
    }
}
