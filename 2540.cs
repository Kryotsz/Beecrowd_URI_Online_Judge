using System;

namespace uri2540
{
    class Program
    {
        static void Main(string[] args)
        {
            string ValorEntrada;
            int N, V, favoravel, desfavoravel;

            while(true){
                ValorEntrada=Console.ReadLine();

                if(string.IsNullOrEmpty(ValorEntrada)){
                    break;
                }
            
                N=int.Parse(ValorEntrada);

                string[] votos=new string[N];
                votos=Console.ReadLine().Split(' ');
                
                favoravel=0;
                desfavoravel=0;

                for(int i=0;i<N;i++){
                    V=int.Parse(votos[i]);

                    if(V==1){
                        favoravel++;
                    }else{
                        desfavoravel++;
                    }
                }

                if(favoravel>=((N/3.0)*2.0)){
                    Console.WriteLine("impeachment");
                }else{
                    Console.WriteLine("acusacao arquivada");
                }
            }
        }
    }
}
