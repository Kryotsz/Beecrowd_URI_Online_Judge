using System;

namespace uri1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, soma=0, cont=0;

            do{
                X=int.Parse(Console.ReadLine());

                if(X==0){
                    break;
                }

                do{
                    if(X%2==0){
                        soma+=X;
                        cont+=1;
                    }
                    X+=1;
                }

                while(cont<5);

                Console.WriteLine(soma);
                soma=0;
                cont=0;
            }

            while(X!=0);
        }
    }
}
