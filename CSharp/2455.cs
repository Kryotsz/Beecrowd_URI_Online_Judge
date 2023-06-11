int P1, P2, C1, C2;

string[] vetor=new string[4];
vetor=Console.ReadLine().Split(' ');
P1=int.Parse(vetor[0]);
C1=int.Parse(vetor[1]);
P2=int.Parse(vetor[2]);
C2=int.Parse(vetor[3]);

if(P1*C1==P2*C2){
    Console.WriteLine('0');
}else if(P1*C1>P2*C2){
    Console.WriteLine("-1");
}else{
    Console.WriteLine('1');
}