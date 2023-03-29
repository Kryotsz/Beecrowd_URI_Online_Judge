// See https://aka.ms/new-console-template for more information
int Xf, Yf, Xi, Yi, Vi, R1, R2, alcanceUltimate;
double distancia;
string entrada;

while(true){
    entrada=Console.ReadLine();

    if(string.IsNullOrEmpty(entrada)){
        break;
    }

    string[] vetor=new string[7];
    vetor=entrada.Split(' ');

    Xf=int.Parse(vetor[0]);
    Yf=int.Parse(vetor[1]);
    Xi=int.Parse(vetor[2]);
    Yi=int.Parse(vetor[3]);
    Vi=int.Parse(vetor[4]);
    R1=int.Parse(vetor[5]);
    R2=int.Parse(vetor[6]);

    distancia=Math.Sqrt(Math.Pow((Xi-Xf),2)+Math.Pow((Yi-Yf),2))+(1.5*Vi);

    alcanceUltimate=(R1+R2);

    if(distancia<=alcanceUltimate){
        Console.WriteLine("Y");
    }else{
        Console.WriteLine("N");
    }
}