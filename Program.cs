//Final 1 !!!!
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void che(int m, int n)
{
if (m > n)
return;
if (m % 2 == 0)
{
Console.Write($"{m}, ");
}
che(m+1,n);

}
che(m,n);

//Final 2!!!

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa(int m, int n)
{
if (m==n)
return n;
else return m + summa(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");



//Final 3!!!

 
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}