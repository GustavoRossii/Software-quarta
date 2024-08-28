// criar um vetor de valores intieros
int tamanho = 100;
int[] vetor = new int [tamanho];
// percorrer o vetor com um laço de repetição
// Gerar um valor aleatoria em c# 
Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    vetor [i] = random.Next(1000);
}
//Imprimir o vetor com valores aleatorios
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i]+" ");
}

bool troca = false;

do{
    troca = false;
for (int i = 0; i < vetor.Length - 1; i++)
{
    if(vetor[i] > vetor[i+1])
    {
        troca = true;
        int aux = vetor[i];
        vetor[i] = vetor[i+1];
        vetor[i+1] = aux;
    }
}
}while(troca == true);

//Array.Sort(vetor); faz a mesma coisa q o de cima funcionalidade do C# 

Console.Write("\n");
//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i]+" ");
}
