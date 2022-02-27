// Программа принимающаю число (N) и выводящая все четные числа от 1 до (N)
Console.Write("Введите число: ");
int N = Convert.ToInt16(Console.ReadLine());
int EvenNumber = 2;
while (EvenNumber <= N)
{
    Console.Write($"{EvenNumber}  ");
    EvenNumber +=2;
}
//Вариант №2 решение
// int count = 1;
// while (count <= N)
// {
//     if (count % 2 == 0)
//     {
//         Console.Write($"{count}  ");
//         count++;
//     }
//     else
//     {
//         count++;
//     }
// }