using System;
using System.Globalization;

namespace uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cont=0;
            double soma=0, media;

            do{
                N=int.Parse(Console.ReadLine());
                if(N<0){
                    break;
                }else{
                    soma+=N;
                    cont+=1;
                }
            }

            while(N>=0);
            media=soma/cont;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
