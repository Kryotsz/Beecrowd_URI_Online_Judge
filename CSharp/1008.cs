using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, horas;
            double valor, SALARY;
            NUMBER=int.Parse(Console.ReadLine());
            horas=int.Parse(Console.ReadLine());
            valor=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            SALARY=valor*horas;
            Console.WriteLine("NUMBER = "+NUMBER);
            Console.WriteLine("SALARY = U$ "+SALARY.ToString("F2",CultureInfo.InvariantCulture));
            

        }
    }
}
