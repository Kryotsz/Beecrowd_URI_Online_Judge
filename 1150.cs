using System;

namespace uri1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Z, soma, cont=1;

            X=int.Parse(Console.ReadLine());
            do{
               Z=int.Parse(Console.ReadLine()); 
            }

            while(Z<=X);

            soma=X;

            // for(int i=X+1;i<=999;i++){
            //     soma+=i;
            //     cont+=1;
            //     if(soma>=Z){
            //         Console.WriteLine(cont);
            //         break;
            //     }
            // }

            int i=X+1;

            do{
                soma+=i; 
                cont+=1; 
                i+=1; 
            }

            while(soma<Z);

            Console.WriteLine(cont);
        }
    }
}
