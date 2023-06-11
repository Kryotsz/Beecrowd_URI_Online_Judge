using System;

namespace uri1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, primeiro=1, segundo=2, terceiro=3;

            N=int.Parse(Console.ReadLine());

            Console.WriteLine(primeiro+" "+segundo+" "+terceiro+" PUM");

            for(int i=1;i<N;i++){
                primeiro=terceiro+2;
                segundo=primeiro+1;
                terceiro=segundo+1;
                Console.WriteLine(primeiro+" "+segundo+" "+terceiro+" PUM");
            }
        }
    }
}
