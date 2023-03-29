using System;
using System.Globalization;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int cont=0;

            for(int i=1;i<=6;i++){
                num=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(num>0){
                    cont+=1;
                }
            }
            Console.WriteLine(cont+" valores positivos");
        }
    }
}
