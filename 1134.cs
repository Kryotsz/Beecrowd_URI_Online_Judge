using System;

namespace uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, alcool=0, gasolina=0, diesel=0;

            do{
              codigo=int.Parse(Console.ReadLine());

              if(codigo<1||codigo>4){
                  codigo=int.Parse(Console.ReadLine());
                  if(codigo==1){
                      alcool+=1;
                  }else if(codigo==2){
                      gasolina+=1;
                  }else if(codigo==3){
                      diesel+=1;
                  }
              }else{
                  if(codigo==1){
                      alcool+=1;
                  }else if(codigo==2){
                      gasolina+=1;
                  }else if(codigo==3){
                      diesel+=1;
                  }
              }
            }
            
            while(codigo!=4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: "+alcool);
            Console.WriteLine("Gasolina: "+gasolina);
            Console.WriteLine("Diesel: "+diesel);
        }
    }
}
