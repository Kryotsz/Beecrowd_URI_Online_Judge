// See https://aka.ms/new-console-template for more information
int N, Q, n, p;
string entrada;

while(true){

    entrada=Console.ReadLine();

    if(string.IsNullOrEmpty(entrada)){
        break;
    }

    string[] vetor=new string[2];
    vetor=entrada.Split(' ');

    // string[] vetor=new string[2];
    // vetor=Console.ReadLine().Split(' ');

    N=int.Parse(vetor[0]);
    Q=int.Parse(vetor[1]);

    List<int> notas = new List<int>();

    for(int i=0;i<N;i++){
        // entrada=Console.ReadLine();

        // if(string.IsNullOrEmpty(entrada)){
        // break;
        // }

        notas.Add(int.Parse(entrada));
    }

    notas.Sort();
    notas.Reverse();

    for(int i=0;i<Q;i++){
        // entrada=Console.ReadLine();

        // if(string.IsNullOrEmpty(entrada)){
        // break;
        // }

        p=int.Parse(entrada);

        Console.WriteLine(notas[p-1]);
    }
}
