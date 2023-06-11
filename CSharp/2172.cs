int X, M, E;

do{
    string[] vetor=new string[2];
    vetor=Console.ReadLine().Split(' ');
    X=int.Parse(vetor[0]);
    M=int.Parse(vetor[1]);

    if(X!=0&&M!=0){
        E=X*M;

        Console.WriteLine(E);
    }
}

while(X!=0&&M!=0);