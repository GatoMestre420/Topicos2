
int[] vetor = new int[10];

//GERAR UM VALOR RANDOMICO 
Random random = new Random();
//Console.WriteLine(random.Next(100));


//PREENCHER O VETOR COM VALORES ALEATÓRIOS ENTRE 1 E 100   cle
for(int i = 0; i < vetor.Length; i++){
    vetor[i] = random.Next(100);
}


 Console.WriteLine("Vetor antes da ordenação:");
//IMPRIMIR OS VALORES ALEATÓRIOS
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}   


    Array.Sort(vetor);



Console.WriteLine("\n");
Console.Write("Vetor depois da ordenação: \n");
//EXIBIR OS VALORES ORDENADOS
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}   



