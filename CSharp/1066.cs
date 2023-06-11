using System;
using System.Globalization;

namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {   
            int par=0, impar=0, positivo=0, negativo=0;
            double num;

            for(int i=1;i<=5;i++){
                num=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(num%2==0){
                    par+=1;
                }
                if(num%2!=0){
                    impar+=1;
                }
                if(num>0){
                    positivo+=1;
                }
                if(num<0){
                    negativo+=1;
                }  
            }
            Console.WriteLine(par+" valor(es) par(es)");
            Console.WriteLine(impar+" valor(es) impar(es)");
            Console.WriteLine(positivo+" valor(es) positivo(s)");
            Console.WriteLine(negativo+" valor(es) negativo(s)");
        }
    }
}
