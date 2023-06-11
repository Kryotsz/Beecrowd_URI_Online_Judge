int posicao=0;

string[] vetor=new string[4];
vetor=Console.ReadLine().Split(' ');

for(int i=0;i<4;i++){
    if(int.Parse(vetor[i])==1){
        posicao=i+1;
    }
}

Console.WriteLine(posicao);