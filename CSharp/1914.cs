using System;

namespace uri1914
{
    class Program
    {
        static void Main(string[] args)
        {
            int QT;

            QT=int.Parse(Console.ReadLine());

            for(int i=1;i<=QT;i++){
                int soma=0;
                string[] vetor=new string[4];
                vetor=Console.ReadLine().Split(' ');
                string nome1=vetor[0];
                string escolha1=vetor[1];
                string nome2=vetor[2];
                string escolha2=vetor[3];

                string[] numeros=new string[2];
                numeros=Console.ReadLine().Split(' ');
                int num1=int.Parse(numeros[0]);
                int num2=int.Parse(numeros[1]);
                soma=num1+num2;

                if(soma%2==0){
                    if(escolha1=="PAR"){
                        Console.WriteLine(nome1);
                    }else{
                        Console.WriteLine(nome2);
                    }
                }else{
                    if(escolha1=="IMPAR"){
                        Console.WriteLine(nome1);
                    }else{
                        Console.WriteLine(nome2);
                    }
                }
            }
        }
    }
}
