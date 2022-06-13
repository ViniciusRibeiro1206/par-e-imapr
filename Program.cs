int numeroDigitado;

Console.Write("Digite um número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

bool numeroEhpar = (numeroDigitado % 2) == 0;

if (numeroEhpar)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"{numeroDigitado} é par");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"{numeroDigitado} é ímpar");
}
Console.ResetColor();