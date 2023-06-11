using System;
using System.Globalization;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario, final, imposto1, imposto2, imposto3, resto;

            salario=decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(salario>=0.00M&&salario<=2000.00M){
                Console.WriteLine("Isento");
            }else if(salario>=2000.01M&&salario<=3000.00M){ //3000 ou 2000.01
                imposto1=(salario-2000.00M)*0.08M;
                Console.WriteLine("R$ "+imposto1.ToString("F2",CultureInfo.InvariantCulture));
            }else if(salario>=3000.01M&&salario<=4500.00M){ //3002
                resto=salario-2000.00M;
                imposto1=1000*0.08M;
                imposto2=(resto-1000)*0.18M;
                final=imposto1+imposto2;
                Console.WriteLine("R$ "+final.ToString("F2",CultureInfo.InvariantCulture));
            }else if(salario>4500.00M){
                resto=salario-2000.00M;
                imposto1=1000*0.08M;
                resto=resto-1000;
                imposto2=1500*0.18M;
                imposto3=(resto-1500)*0.28M;
                final=imposto1+imposto2+imposto3;
                Console.WriteLine("R$ "+final.ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
