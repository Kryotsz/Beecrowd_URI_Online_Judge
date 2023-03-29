using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, comissao, total;

            nome=Console.ReadLine();
            salario=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vendas=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            comissao=vendas*0.15;
            total=salario+comissao;
            Console.WriteLine("TOTAL = R$ "+total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
