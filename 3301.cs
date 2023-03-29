using System;

namespace uri3301
{
    class Program
    {
        static void Main(string[] args)
        {
            int H, Z, L;
            string[] idades=new string[3];

            idades=Console.ReadLine().Split(' ');
            H=int.Parse(idades[0]);
            Z=int.Parse(idades[1]);
            L=int.Parse(idades[2]);

            if(H>Z&&Z>L){
                Console.WriteLine("zezinho");
            }else if(H>L&&L>Z){
                Console.WriteLine("luisinho");
            }else if(Z>H&&H>L){
                Console.WriteLine("huguinho");
            }else if(Z>L&&L>H){
                Console.WriteLine("luisinho");
            }else if(L>H&&H>Z){
                Console.WriteLine("huguinho");
            }else if(L>Z&&Z>H){
                Console.WriteLine("zezinho");
            }
        }
    }
}
