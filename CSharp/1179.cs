using System;

namespace uri1179
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, contpar=0, contimpar=0, entrada=0;
            int[] vetorpar=new int[5]; 
            int[] vetorimpar=new int[5];

            do{
                N=int.Parse(Console.ReadLine());
                entrada+=1;

                if(N%2==0){
                    vetorpar[contpar]=N;
                    contpar+=1;
                }else{
                    vetorimpar[contimpar]=N;
                    contimpar+=1;
                }

                if(contpar==5){
                    for(int i=0;i<=4;i++){
                        Console.WriteLine("par["+i+"] = "+vetorpar[i]);
                    }
                    contpar=0;
                }

                if(contimpar==5){
                    for(int c=0;c<=4;c++){
                        Console.WriteLine("impar["+c+"] = "+vetorimpar[c]);
                    }
                    contimpar=0;
                }
            }

            while(entrada<15);

            for(int c=0;c<contimpar;c++){
                Console.WriteLine("impar["+c+"] = "+vetorimpar[c]);
            }

            for(int i=0;i<contpar;i++){
                Console.WriteLine("par["+i+"] = "+vetorpar[i]);
            }   
        }
    }
}
