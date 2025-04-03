Console.WriteLine("Informe o Primeiro Numero:");
string input1 = Console.ReadLine();
int n1;

if(int.TryParse(input1,out n1)){
    Console.WriteLine("Infome o segundo numero:");
    string input2 = Console.ReadLine();
    int n2;

    if(int.TryParse(input2, out n2)){
        if(n1>n2){
            Console.WriteLine("O primeiro valor é maior que o segundo!");
        }else if (n2>n1){
            Console.WriteLine("O Segundo Valor é maior que o primeiro");
        }
        else{
            Console.WriteLine("Os numeros são iguais!");
        }
    }else{
        Console.WriteLine("O segundo valor é invalido!");
    }
}else{
    Console.WriteLine("O primeiro numero não é válido!");
}

