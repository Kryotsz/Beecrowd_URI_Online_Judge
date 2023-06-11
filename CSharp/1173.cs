using System;

namespace uri1173
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N=new int[10];
            int V;

            V=int.Parse(Console.ReadLine());

            for(int i=0;i<10;i++){
                if(i==0){
                    N[i]=V;
                }else{
                    N[i]=V*2;
                    V=V*2;
                }
                Console.WriteLine("N["+i+"] = "+N[i]);
            }
        }
    }
}
