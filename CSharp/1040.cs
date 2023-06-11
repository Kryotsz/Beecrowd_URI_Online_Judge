using System;
using System.Globalization;

namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, media, exame, mediafinal;
            string[] vetor=new string[4];

            vetor=Console.ReadLine().Split(' ');
            N1=double.Parse(vetor[0],CultureInfo.InvariantCulture);
            N2=double.Parse(vetor[1],CultureInfo.InvariantCulture);
            N3=double.Parse(vetor[2],CultureInfo.InvariantCulture);
            N4=double.Parse(vetor[3],CultureInfo.InvariantCulture);

            media=(N1*2+N2*3+N3*4+N4*1)/10;

            Console.WriteLine("Media: "+media.ToString("F1",CultureInfo.InvariantCulture));

            if(media>=7.0){
                Console.WriteLine("Aluno aprovado.");
            }else{
                if(media<5.0){
                Console.WriteLine("Aluno reprovado.");  
            }else{
                if(media>=5.0&&media<=6.9){
                Console.WriteLine("Aluno em exame.");

                exame=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: "+exame.ToString("F1",CultureInfo.InvariantCulture));

                mediafinal=(media+exame)/2;

                if(mediafinal>=5.0){
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: "+mediafinal.ToString("F1",CultureInfo.InvariantCulture));
                }else{
                     if(mediafinal<=4.9){
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: "+mediafinal.ToString("F1",CultureInfo.InvariantCulture));
                }
                }
            }
            }
            }
        }
    }
}
