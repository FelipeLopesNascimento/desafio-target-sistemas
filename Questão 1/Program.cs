Console.Write("Digite um número: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int numero))
{
    int a = 0, b = 1;
    while (b <= numero)
    {
        if (b == numero)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            return;
        }
        int temp = b;
        b = a + b;
        a = temp;
    }

    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
}
