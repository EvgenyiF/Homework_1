// Задача 4. Найти максимальное число из 3-х.
//Console.Write($"Введите количество чисел: "); // Две строчки для изменения условия задачи
//int n = Convert.ToInt16(Console.ReadLine()); // Вместо 3 чисел можно ввести любое количество
int n = 3; //Согласно условию задачи 3 числа для сравнения
int[] array = new int[n];
int max = 0;
Random r = new Random();
for (int count = 0; count < n; count++)
{
    //array[count] = r.Next(-100, 101); // Две строчки для рандомного заполнения числами
    //Console.Write($"{array[count]} ");
    Console.Write($"Введите {count + 1} число "); //Вместо ввода вручную чисел 3 строчки(с12 по14) можно 
    int FirstNumber = Convert.ToInt16(Console.ReadLine()); // использовать 10-11 строки
    array[count] = FirstNumber;
}
for (int count = 0; count < n; count++)
{
    if (max < array[count])
        max = array[count];
}
Console.WriteLine($"\n max = {max}");