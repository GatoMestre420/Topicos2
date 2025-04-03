// Console.WriteLine("Informe um numero:");
// int n1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Informe o Segundo Numero:");
// int n2 = int.Parse(Console.ReadLine());

// int soma = n1 + n2;
// Console.WriteLine($"A soma dos numeros é :{soma}");
// Console.WriteLine("\n...............................");


//Usando Int.TryParse() , recomendado pois é mais seguro

Console.WriteLine("Informe um numero:");
string input1 = Console.ReadLine();
int n1;

if (int.TryParse(input1, out n1)){
    Console.WriteLine("Informe o Segundo Numero:");
    string input2 = Console.ReadLine();
    int n2;

    if (int.TryParse(input2, out n2)){
        int soma = n1 + n2;
        Console.WriteLine("A soma dos numeros é:" + soma);
    }else
    {
        Console.WriteLine("Valor Inválido para o segundo numero:");
    }
    }else{
        Console.WriteLine("Valor inválido para o primeiro numero:");
    }


