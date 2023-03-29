int T, A, B, C, D, E, acertos=0;

string[] vetor=new string[5];

T=int.Parse(Console.ReadLine());

vetor=Console.ReadLine().Split(' ');
A=int.Parse(vetor[0]);
B=int.Parse(vetor[1]);
C=int.Parse(vetor[2]);
D=int.Parse(vetor[3]);
E=int.Parse(vetor[4]);

if(T==A){
    acertos+=1;
}

if(T==B){
    acertos+=1;
}

if(T==C){
    acertos+=1;
}

if(T==D){
    acertos+=1;
}

if(T==E){
    acertos+=1;
}

Console.WriteLine(acertos);