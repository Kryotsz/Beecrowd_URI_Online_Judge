using System;
using System.Globalization;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, maior=0, meio=0, menor=0;
            string[] vetor=new string[3];

            vetor=Console.ReadLine().Split(' ');
            A=double.Parse(vetor[0],CultureInfo.InvariantCulture);
            B=double.Parse(vetor[1],CultureInfo.InvariantCulture);
            C=double.Parse(vetor[2],CultureInfo.InvariantCulture);

            if(A>B&&B>C){
                maior=A;
                meio=B;
                menor=C;
            }else if(A>C&&C>B){
                maior=A;
                meio=C;
                menor=B;
            }else if(B>A&&A>C){
                maior=B;
                meio=A;
                menor=C;
            }else if(B>C&&C>A){
                maior=B;
                meio=C;
                menor=A;
            }else if(C>A&&A>B){
                maior=C;
                meio=A;
                menor=B;
            }else if(C>B&&B>A){
                maior=C;
                meio=B;
                menor=A;
            }else if(A==B&&B==C){
                maior=A;
                meio=B;
                menor=C;
            }else if(A==B&&B>C||B==C&&A>B){
                maior=A;
                meio=B;
                menor=C;
            }else if(A==B&&C>B){
                maior=C;
                meio=A;
                menor=B;
            }else if(B>A&&A==C){
                maior=B;
                meio=A;
                menor=C;
            }else if(A==C&&A>B){
                maior=A;
                meio=C;
                menor=B;
            }
            
            A=maior;
            B=meio;
            C=menor;

            if(A>=(B+C)){
                Console.WriteLine("NAO FORMA TRIANGULO");
            }else{
                if(Math.Pow(A,2)==(Math.Pow(B,2)+Math.Pow(C,2))){
                Console.WriteLine("TRIANGULO RETANGULO");
            }if(Math.Pow(A,2)>(Math.Pow(B,2)+Math.Pow(C,2))){
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }if(Math.Pow(A,2)<(Math.Pow(B,2)+Math.Pow(C,2))){
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }if(A==B&&B==C){
                Console.WriteLine("TRIANGULO EQUILATERO");
            }if(A==B&&C!=B||C==A&&A!=B||B==C&&C!=A){
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            }  
        }
    }
}

