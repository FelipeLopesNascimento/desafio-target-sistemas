Console.Write("Digite uma string: ");
  
string texto = Console.ReadLine();
int contador = 0;
foreach (char c in texto)
    {
        if (char.ToLower(c) == 'a')
        {
            contador++;
        }
    }
Console.WriteLine($"A letra 'a' aparece {contador} vezes na string.");