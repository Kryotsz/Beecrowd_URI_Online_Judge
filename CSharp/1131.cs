using System;

namespace uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int inter, gremio, resposta, cont=0, vitoriainter=0, vitoriagremio=0, empates=0;
            string[] gols=new string[2];

            do{
            gols=Console.ReadLine().Split(' ');
            inter=int.Parse(gols[0]);
            gremio=int.Parse(gols[1]);

            if(inter>gremio){
                vitoriainter+=1;
            }else if(gremio>inter){
                vitoriagremio+=1;
            }else{
                empates+=1;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            resposta=int.Parse(Console.ReadLine());
            cont+=1;
            }

            while(resposta==1);

            Console.WriteLine(cont+" grenais");
            Console.WriteLine("Inter:"+vitoriainter);
            Console.WriteLine("Gremio:"+vitoriagremio);
            Console.WriteLine("Empates:"+empates);

            if(inter>gremio){
                Console.WriteLine("Inter venceu mais");
            }else if(gremio>inter){
                Console.WriteLine("Gremio venceu mais");
            }else{
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
