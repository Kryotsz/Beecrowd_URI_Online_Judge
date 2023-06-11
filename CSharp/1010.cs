using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, num, codigo2, num2;
            double unit, unit2, valor, valor2, final;

            string[] a=new string[3];
            string[] b=new string[3];
            a=Console.ReadLine().Split(' ');
            b=Console.ReadLine().Split(' ');

            codigo=int.Parse(a[0]);
            num=int.Parse(a[1]);
            unit=double.Parse(a[2],CultureInfo.InvariantCulture);
            codigo2=int.Parse(b[0]);
            num2=int.Parse(b[1]);
            unit2=double.Parse(b[2],CultureInfo.InvariantCulture);

            valor=num*unit;
            valor2=num2*unit2;
            final=valor+valor2;

            Console.WriteLine("VALOR A PAGAR: R$ "+final.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
