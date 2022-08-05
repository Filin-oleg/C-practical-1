// программа: Если введено полодительное число, то возводим его в квадрат

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()); // number = Convert.ToInt32(Console.ReaDLINE());

if (number > 0)
{
    number *= number;
    Console.WriteLine("Число возведенное в квадрат: " + number);
    //Console.WriteLine(number);
}
else 
{
    Console.WriteLine("Число отрицательное");
}
