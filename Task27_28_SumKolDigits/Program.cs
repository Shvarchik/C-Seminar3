// Определить количество цифр в числе (27) и посчитать сумму цифр чила (28)

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
if (A < 0) A = -A;
int TempA = A;
int Sum = 0;
int Num = 0;
do 
    {
        Sum = Sum + TempA % 10;
        Num++;
        TempA = TempA / 10;
    }
while (TempA!=0);

Console.WriteLine($"Количество цифр в числе {A} - {Num}, их сумма равна {Sum}");