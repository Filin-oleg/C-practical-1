// Задача. Написать программу, которая будет выдавать название дня недели по заданному номеру

internal class Programm
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер, соответствующий дню недели ");
        int number = int.Parse(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("День недели с номером 1 - это понедельник");
        }
        if (number == 2)
        {
            Console.WriteLine("День недели с номером 2 - это вторник");
        }
        if (number == 3)
        {
            Console.WriteLine("День недели с номером 3 - это среда");
        }
        if (number == 4)
        {
            Console.WriteLine("День недели с номером 4 - это четверг");
        }
        if (number == 5)
        {
            Console.WriteLine("День недели с номером 5 - это пятница");
        }
        if (number == 6)
        {
            Console.WriteLine("День недели с номером 6 - это суббота");
        }
        if (number == 7)
        {
            Console.WriteLine("День недели с номером 7 - это воскресенье");
        }
        if (number > 7)
        {
            Console.WriteLine("Такого дня недели не существует");
        }
        if (number < 1)
        {
            Console.WriteLine("Такого дня недели не существует");
        }
    }
}