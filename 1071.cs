using System;

namespace uri1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, soma=0;

            X=int.Parse(Console.ReadLine());
            Y=int.Parse(Console.ReadLine());

            for(int i=X;i<=Y;i++){
                if(i%2!=0){
                    soma+=i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
