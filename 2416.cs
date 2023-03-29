int C, N, resto;

string[] vetor=new string[2];
vetor=Console.ReadLine().Split(' ');
C=int.Parse(vetor[0]);
N=int.Parse(vetor[1]);

resto=C-N;

do{
    resto-=N;
}

while(resto>=N);

Console.WriteLine(resto);