using System;
using System.Globalization;

namespace uri1064
{
    class Program
    {
        static void Main(string[] args)
        {   
            double num, soma=0, media=0;
            int cont=0;

            for(int i=1;i<=6;i++){
                num=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(num>0){
                    cont+=1;
                    soma+=num;
                }

            }
            media=soma/cont;
            Console.WriteLine(cont+" valores positivos");
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
