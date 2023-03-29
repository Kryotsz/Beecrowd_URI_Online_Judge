using System;
using System.Globalization;

namespace uri1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double I=0, J=1;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F0",CultureInfo.InvariantCulture)+" J="+J.ToString("F0",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //0.2
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F1",CultureInfo.InvariantCulture)+" J="+J.ToString("F1",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //0.4
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F1",CultureInfo.InvariantCulture)+" J="+J.ToString("F1",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //0.6
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F1",CultureInfo.InvariantCulture)+" J="+J.ToString("F1",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //0.8
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F1",CultureInfo.InvariantCulture)+" J="+J.ToString("F1",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //1
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F0",CultureInfo.InvariantCulture)+" J="+J.ToString("F0",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //1.2
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F1",CultureInfo.InvariantCulture)+" J="+J.ToString("F1",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //1.4
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F1",CultureInfo.InvariantCulture)+" J="+J.ToString("F1",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //1.6
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F1",CultureInfo.InvariantCulture)+" J="+J.ToString("F1",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //1.8
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F1",CultureInfo.InvariantCulture)+" J="+J.ToString("F1",CultureInfo.InvariantCulture));
                J+=1;
            }

            I+=0.2; //2
            J=1;
            J+=I;

            for(int i=1;i<=3;i++){
                Console.WriteLine("I="+I.ToString("F0",CultureInfo.InvariantCulture)+" J="+J.ToString("F0",CultureInfo.InvariantCulture));
                J+=1;
            }
        }
    }
}
