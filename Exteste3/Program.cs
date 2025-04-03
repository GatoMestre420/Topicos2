Console.WriteLine("Informe um numero:");
string input1 = Console.ReadLine();
int n1;

if(int.TryParse(input1, out n1)){
    if(n1 % 2 == 0){
        Console.WriteLine($"O numero {n1} é par");
    }else{
        Console.WriteLine($"O numero {n1} é impar");
    }
}else{
    Console.WriteLine($"O numero {n1} é inválido.");
}