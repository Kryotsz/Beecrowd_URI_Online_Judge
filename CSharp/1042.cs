using System;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor=new string[3];
            int A, B, C, maior=0, meio=0, menor=0;

            vetor=Console.ReadLine().Split(' ');
            A=int.Parse(vetor[0]);
            B=int.Parse(vetor[1]);
            C=int.Parse(vetor[2]);

            if(A<B&&B<C){
                menor=A;
                meio=B;
                maior=C;
                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);
            }else if(A<C&&C<B){
                menor=A;
                meio=C;
                maior=B;
                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);
            }else if(B<A&&A<C){
                menor=B;
                meio=A;
                maior=C;
                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);
            }else if(B<C&&C<A){
                menor=B;
                meio=C;
                maior=A;
                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);
            }else if(C<A&&A<B){
                menor=C;
                meio=A;
                maior=B;
                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);
            }else if(C<B&&B<A){
                menor=C;
                meio=B;
                maior=A;
                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);
            }
            Console.WriteLine("");
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
