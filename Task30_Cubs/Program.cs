// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

if (N % 2 == 0)
    Console.WriteLine ($"{N} в кубе равно {N*N*N}");
else
    Console.WriteLine($"{N} заканчивается на нечетную цифру");
