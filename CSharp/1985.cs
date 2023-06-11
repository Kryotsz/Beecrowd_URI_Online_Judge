using System.Globalization;

int p, q, opcao;
decimal preco, total=0;

p=int.Parse(Console.ReadLine());

for(int i=1;i<=p;i++){
    string[] vetor=new string[2];
    vetor=Console.ReadLine().Split(' ');
    opcao=int.Parse(vetor[0]);
    q=int.Parse(vetor[1]);

    if(opcao==1001){
        preco=1.50M;
        total+=preco*q;
    }else if(opcao==1002){
        preco=2.50M;
        total+=preco*q;
    }else if(opcao==1003){
        preco=3.50M;
        total+=preco*q;
    }else if(opcao==1004){
        preco=4.50M;
        total+=preco*q;
    }else if(opcao==1005){
        preco=5.50M;
        total+=preco*q;
    }
}

Console.WriteLine(total.ToString("F2",CultureInfo.InvariantCulture));