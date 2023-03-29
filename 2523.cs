// See https://aka.ms/new-console-template for more information
while(true){
    string entrada=Console.ReadLine();

    if(string.IsNullOrEmpty(entrada)){
        break;
    }

    string mensagem="";
    string alfabeto = entrada;
    int N = int.Parse(Console.ReadLine());

    string[] vetor = new string[N];
    vetor=Console.ReadLine().Split(' ');

    for(int i = 0; i < N; i++){
        int numero = int.Parse(vetor[i]);
        char letra = alfabeto[numero-1];

        mensagem+=letra;
    }

    Console.WriteLine(mensagem);
}
