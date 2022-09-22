Console.Clear();

Console.WriteLine("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()!));
int thirdDigit = 0;

if(number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while(number > 999)
    {
        number = number / 10;
    }
    thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра: {thirdDigit}");
}

// Второй способ - через строку (проверяла, работает):
// Console.Clear();
// Console.Write("Введите число: ");
// int number = Math.Abs(int.Parse(Console.ReadLine()!));
// string numstring = Convert.ToString(number);
// if (numstring.Length < 3)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else 
// {
//     Console.WriteLine($"Третья цифра: {numstring[2]}");
// }