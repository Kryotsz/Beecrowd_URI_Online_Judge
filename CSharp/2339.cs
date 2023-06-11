int C, P, F;

string[] vetor=new string[3];
vetor=Console.ReadLine().Split(' ');
C=int.Parse(vetor[0]);
P=int.Parse(vetor[1]);
F=int.Parse(vetor[2]);

if(C*F<=P){
    Console.WriteLine('S');
}else{
    Console.WriteLine('N');
}