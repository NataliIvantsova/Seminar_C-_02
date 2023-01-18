// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int InputInt(string messege)// вводим целочисленное значение InputInt содержащее строку сообщения
{
    System.Console.Write(messege);//введите сообщение
    int x = Convert.ToInt32(Console.ReadLine());//значению х = прочитать строку
    return x;//вывести значение х из предыдущей строки
}

int a = InputInt("Введите число > ");
int b = 7;
int c = 23;

if(a%b == 0 && a%c == 0)
{
    System.Console.WriteLine($"число {a} кратно одновременно {b} и {c}");
}
else
{
      System.Console.WriteLine($"число {a} не кратно одновременно {b} и {c}");
}

