using System;
using System.Globalization;

namespace uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, soma=0, media;
            int X=1, validas=0;

            do{
                nota=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(nota<=0||nota>10){
                    Console.WriteLine("nota invalida");
                }else{
                    soma+=nota;
                    validas+=1;
                }

                if(validas==2){
                    media=soma/2;
                    Console.WriteLine("media = "+media.ToString("F2",CultureInfo.InvariantCulture));

                    do{
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        X=int.Parse(Console.ReadLine());
                        if(X==1){
                            validas=0;
                            media=0;
                            soma=0;
                        }
                    }

                    while(X<1||X>2);
                }            
            }

            while(X==1);
        }   
    }
}
