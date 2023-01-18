// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


// System.Console.WriteLine("Введите трёхзначное число >");

// int A = Convert.ToInt32(Console.ReadLine());

// if (A > 99 && A < 1000)
// {
//     int result = A % 10;
//     System.Console.WriteLine($"Послдедняя цифра числа = {result}");
// }
// else
// {
//     System.Console.WriteLine("Число не трехзначное");
// }
// со строки 21- 26 написана функция
int InputInt(string messege)// вводим целочисленное значение InputInt содержащее строку сообщения
{
    System.Console.WriteLine(messege);//введите сообщение
    int x = Convert.ToInt32(Console.ReadLine());//значению х = прочитать строку
    return x;//вывести значение х из предыдущей строки
}

int A = InputInt("Введите трехзначное число > ");
if (A > 99 && A < 1000)
{
    int result = A % 10;
    System.Console.WriteLine($"Послдедняя цифра числа = {result}");
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}
