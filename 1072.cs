using System;

namespace uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, dentro=0, fora=0;

            N=int.Parse(Console.ReadLine());

            for(int i=1;i<=N;i++){
                X=int.Parse(Console.ReadLine());
                if(X>=10.0&&X<=20.0){
                    dentro+=1;
                }else{
                    fora+=1;
                }
            }
            Console.WriteLine(dentro+" in");
            Console.WriteLine(fora+" out");
        }
    }
}
