int N, V, cont=0, controle=0;

N=int.Parse(Console.ReadLine());

for(int i=1;i<=N;i++){
    V=int.Parse(Console.ReadLine());

    if(cont==0){
        controle=V;
        cont+=1;
    }else{
        if(V!=controle){
            cont+=1;
            controle=V;
        }
    }
}

Console.WriteLine(cont);