Console.Clear();

Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);

if((number < 1) || (number > 7))
{
    Console.WriteLine("Нет такого номера дня недели!");
}
else if((number >= 1) && (number <= 5))
{
    Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("Это выходной день");
}

