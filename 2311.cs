// See https://aka.ms/new-console-template for more information
using System.Globalization;

int N;
string nome, entrada;
double GD, resultado;

double[] notas = new double[7];
string[] controle = new string[7];

N=int.Parse(Console.ReadLine());

for(int i=0;i<N;i++){
    nome=Console.ReadLine();
    GD=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    controle=Console.ReadLine().Split(' ');

    for(int c=0;c<7;c++){
        notas[c]=double.Parse(controle[c],CultureInfo.InvariantCulture);
    }

    Array.Sort(notas);

    resultado=(notas[1]+notas[2]+notas[3]+notas[4]+notas[5])*GD;

    Console.WriteLine(nome+" "+resultado.ToString("F2", CultureInfo.InvariantCulture));
}
