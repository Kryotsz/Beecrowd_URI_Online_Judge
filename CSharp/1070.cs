using System;

namespace uri1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, cont;

            X=int.Parse(Console.ReadLine());

            cont=0;
            for (int i=X; cont<6; i++){
                if(i%2!=0){
                Console.WriteLine(i);
                cont+=1;
            }

            }
        }
    }
}
