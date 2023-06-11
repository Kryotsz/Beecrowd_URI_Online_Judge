int N, T, V, distancia=0;

N=int.Parse(Console.ReadLine());

for(int i=0;i<N;i++){
    string[] vetor=new string[2];
    vetor=Console.ReadLine().Split(' ');
    T=int.Parse(vetor[0]);
    V=int.Parse(vetor[1]);

    distancia+=T*V;
}

Console.WriteLine(distancia);
