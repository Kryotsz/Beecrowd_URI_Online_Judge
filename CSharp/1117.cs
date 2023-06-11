using System;
using System.Globalization;

namespace uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, soma=0, media=0;
            int cont=0;

            do{
                nota=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(nota<0||nota>10){
                    Console.WriteLine("nota invalida");
                }else{
                    soma+=nota;
                    cont+=1;
                }
                media=soma/2;
                if(cont==2){
                    Console.WriteLine("media = "+media.ToString("F2",CultureInfo.InvariantCulture));
                }  
            }
            while(cont<2);
        }
    }
}
