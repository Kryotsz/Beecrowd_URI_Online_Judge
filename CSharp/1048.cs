using System;
using System.Globalization;

namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novosalario, reajuste;
            int percentual;

            salario=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(salario>=0&&salario<=400.00){
                reajuste=salario*0.15;
                percentual=15;
                novosalario=salario+reajuste;
                Console.WriteLine("Novo salario: "+novosalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: "+reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: "+percentual+" %");

            }

            if(salario>=400.01&&salario<=800.00){
                reajuste=salario*0.12;
                percentual=12;
                novosalario=salario+reajuste;
                Console.WriteLine("Novo salario: "+novosalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: "+reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: "+percentual+" %");
            }

             if(salario>=800.01&&salario<=1200.00){
                reajuste=salario*0.10;
                percentual=10;
                novosalario=salario+reajuste;
                Console.WriteLine("Novo salario: "+novosalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: "+reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: "+percentual+" %");
            }

             if(salario>=1200.01&&salario<=2000.00){
                reajuste=salario*0.07;
                percentual=7;
                novosalario=salario+reajuste;
                Console.WriteLine("Novo salario: "+novosalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: "+reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: "+percentual+" %");
            }

             if(salario>2000.00){
                reajuste=salario*0.04;
                percentual=4;
                novosalario=salario+reajuste;
                Console.WriteLine("Novo salario: "+novosalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: "+reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: "+percentual+" %");
            }
        }
    }
}
