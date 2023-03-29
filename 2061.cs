int N, M;
string A;

string[] vetor=new string[2];
vetor=Console.ReadLine().Split(' ');
N=int.Parse(vetor[0]);
M=int.Parse(vetor[1]);

for(int i=0;i<M;i++){
    A=Console.ReadLine();
    if(A=="fechou"){
        N+=1;
    }else if(A=="clicou"){
        N-=1;
    }
}

Console.WriteLine(N);
