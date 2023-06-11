int N, S, M, menor;

string[] vetor=new string[2];
vetor=Console.ReadLine().Split(' ');
N=int.Parse(vetor[0]);
S=int.Parse(vetor[1]);

menor=S;

for(int i=1;i<=N;i++){
    M=int.Parse(Console.ReadLine());

    S+=M;

    if(menor>S){
        menor=S;
    }
}

Console.WriteLine(menor);