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

            if(X>Y){
                for(int i=Y+1;i<X;i++){
                    if(i%2!=0){
                        soma+=i;
                    }
                }
            }else{
                for(int i=X+1;i<Y;i++){
                    if(i%2!=0){
                        soma+=i;
                    }
                }
            }            
            Console.WriteLine(soma);
        }
    }
}
