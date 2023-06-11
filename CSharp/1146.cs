using System;

namespace uri1146
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;

            do{
                X=int.Parse(Console.ReadLine());

                for(int i=1;i<=X;i++){
                    if(i<X){
                        Console.Write(i+" ");
                    }else if(i==X){
                        Console.WriteLine(i);
                    }
                } 
            }
            while(X!=0);
        }
    }
}
