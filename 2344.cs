int N;
char nota='a';

N=int.Parse(Console.ReadLine());

if(N==0){
    nota='E';
}else if(N>=1&&N<=35){
    nota='D';
}else if(N>=36&&N<=60){
    nota='C';
}else if(N>=61&&N<=85){
    nota='B';
}else if(N>=86&&N<=100){
    nota='A';
}

Console.WriteLine(nota);