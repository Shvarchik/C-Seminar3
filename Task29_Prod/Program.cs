// Произведение чисел от 1 до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int Prod = 1;
for (int i=2; i <= N; i++)
    Prod = Prod*i;
Console.WriteLine($"Произведение чисел от 1 до {N} равно {Prod}");

