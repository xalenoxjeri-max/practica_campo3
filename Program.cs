// See https://aka.ms/new-console-template for more information

int numero;
bool esPrimo = true;

Console.WriteLine("ingresa un numero");
numero = int.Parse(Console.ReadLine());

if (numero <= 1)
{
    esPrimo = false;
}
else
{
    for (int i = 2; i <= numero / 2; i++)
    {
        if (numero % i == 0)
        {
            esPrimo = false;
            break;
        }
    }
}
if (esPrimo)
    Console.WriteLine($" {numero} es un numero primo.");
else
    Console.WriteLine($"{numero} no es un numero primo.");

