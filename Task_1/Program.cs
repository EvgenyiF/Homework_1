// Задача 2. Программа сравнения 2-х чисел
Console.Write("Введите первое число ");
int FirstNumber = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число ");
int SecondNumber = Convert.ToInt16(Console.ReadLine());
if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"Max число равно {FirstNumber}, а минимальное  равно {SecondNumber}");
}
else
{
Console.WriteLine($"Max число равно {SecondNumber}, а минимальное равно {FirstNumber}");
}