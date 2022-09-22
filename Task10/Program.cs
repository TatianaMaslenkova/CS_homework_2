Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()!));

if((number <= 99) || (number > 999))
{
    Console.WriteLine("Нужно ввести трехзначное число!");
}
else
{
    Console.WriteLine($"Вторая цифра числа: {number/ 10 % 10}");
}