using System;

namespace uri1099
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor=new string[2];

            int N=int.Parse(Console.ReadLine());

            for(int i=1;i<=N;i++){
                int soma=0;
                vetor=Console.ReadLine().Split(' ');
                int X=int.Parse(vetor[0]);
                int Y=int.Parse(vetor[1]);

                if(X<Y){
                    for(int c=X+1;c<Y;c++){
                        if(c%2!=0){
                            soma+=c;
                        }
                    }
                    Console.WriteLine(soma);
                }else{
                    for(int c=Y+1;c<X;c++){
                        if(c%2!=0){
                            soma+=c;
                        }
                    }
                    Console.WriteLine(soma);
                }
            }
        }
    }
}
