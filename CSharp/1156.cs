using System;
using System.Globalization;

namespace uri1156
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal S=1M;
            int soma=1;

            for(int i=1;i<=26;i+=2){
                soma=soma+soma;
                S+=(decimal)(i+2)/(soma);
            }
            
            Console.WriteLine(S.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
