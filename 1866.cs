using System;

namespace uri1866
{
    class Program
    {
        static void Main(string[] args)
        {
            int C, N;

            C=int.Parse(Console.ReadLine());

            for(int i=1;i<=C;i++){
                N=int.Parse(Console.ReadLine());
                if(N%2!=0){
                    Console.WriteLine("1");
                }else{
                    Console.WriteLine("0");
                }
            }
        }
    }
}
