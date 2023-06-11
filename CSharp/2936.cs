int N, cont=0, quantidade=0;

do{
    N=int.Parse(Console.ReadLine());

    if(cont==0){
        quantidade=N*300;
    }else if(cont==1){
        quantidade+=N*1500;
    }else if(cont==2){
        quantidade+=N*600;
    }else if(cont==3){
        quantidade+=N*1000;
    }else if(cont==4){
        quantidade+=N*150;
    }

    cont+=1;
}

while(cont<5);

Console.WriteLine(quantidade+225);

