// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите степень: ");
int B = int.Parse(Console.ReadLine() ?? "0");
int Result = 1;
int index = 0;
while (index<B)
    {
        Result = Result*A;
        index++;
    }
// for (int index = 1; index <= B; index++)
//    Result = Result*A;

Console.WriteLine ($"{A} в степени {B} равно {Result}");