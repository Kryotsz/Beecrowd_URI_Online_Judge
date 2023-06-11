using System;

namespace uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, pares=0;

            for(int i=1;i<=5;i++){
                N=int.Parse(Console.ReadLine());
                if(N%2==0){
                    pares+=1;
                }
            }
            Console.WriteLine(pares+" valores pares");
        } 
    }
}
