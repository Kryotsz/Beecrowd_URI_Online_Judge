// A corrida de lesmas é um esporte que cresceu muito nos últimos anos, fazendo com que várias pessoas dediquem suas vidas tentando capturar lesmas velozes, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de capturar lesmas velozes não é uma tarefa muito fácil, pois praticamente todas as lesmas são muito lentas. Cada lesma é classificada em um nível dependendo de sua velocidade:


// Nível 1: Se a velocidade é menor que 10 cm/h .
// Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
// Nível 3: Se a velocidade é maior ou igual a 20 cm/h .


// Sua tarefa é identificar qual nível de velocidade da lesma mais veloz de um grupo de lesmas.
// Entrada

// A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro L (1 ≤ L ≤ 500) representando o número de lesmas do grupo, e a segunda linha contém L inteiros Vi (1 ≤ Vi ≤ 50) representando as velocidades de cada lesma do grupo.

// A entrada termina com o fim do arquivo (EOF).
// Saída

// Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da lesma mais veloz do grupo.

while(true){
    string entrada = Console.ReadLine();

    if(string.IsNullOrEmpty(entrada)){
        break;
    }

    int L = int.Parse(entrada);

    string[] velocidadesString = new string[L];
    velocidadesString = Console.ReadLine().Split(' ');

    int[] velocidadesInt = new int[L];

    for(int c=0;c<L;c++){
        velocidadesInt[c]=int.Parse(velocidadesString[c]);
    }

    int maior=0;

    foreach(int V in velocidadesInt){
        if(V>maior){
            maior=V;
        }
    }

    if(maior>=20){
        Console.WriteLine("3");
    }else if(maior>=10&&maior<20){
        Console.WriteLine("2");
    }else{
        Console.WriteLine("1");
    }
}
