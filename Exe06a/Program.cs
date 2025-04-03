//PASSOS PARA RESOLVER O EXERCICIO 
// 1- CRIAR UM VETOR DE 100 POSIÇÕES 
// 2- PREENCHER O VETOR COM OS VALORES ALEATÓRIOS 
// 3- IMPRIMIR O VETOR NA TELA 
// 4- ORDENAR O VETOR COM O BUBBLE SORT     


//CRIAR UM VETOR COM VALORES INTEIROS 
using System.Globalization;

int[] vetor = new int[10];

//GERAR UM VALOR RANDOMICO 
Random random = new Random();
//Console.WriteLine(random.Next(100));


//PREENCHER O VETOR COM VALORES ALEATÓRIOS ENTRE 1 E 100   
for(int i = 0; i < vetor.Length; i++){
    vetor[i] = random.Next(100);
}


 Console.WriteLine("Vetor antes da ordenação:");
//IMPRIMIR OS VALORES ALEATÓRIOS
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}   




int n = vetor.Length;

//PERCORRER TODOS OS ELEMENTOS DO VETOR
for(int i = 0; i < n - 1; i ++  ){
    // A CADA INTERAÇÃO, O MAIOR VALOR "SOBE" PARA A POSIÇÃO CORRETA
    for( int j = 0; j < n - i - 1; j++){
        //TROCAR SE O ELEMENTO ATUAL FOR MAIOR QUE O PRÓXIMO
        if(vetor[j] > vetor[j + 1]){
            int temp = vetor[j];
            vetor[j] = vetor[j + 1];
            vetor[j + 1] = temp;
        }
        Console.WriteLine(n + " " + i );

    }

}

// Console.WriteLine("\n");
// Console.Write("Vetor depois da ordenação: \n");
// //EXIBIR OS VALORES ORDENADOS
// for(int i = 0; i < vetor.Length; i++){
//     Console.Write(vetor[i] + " ");
// }   



