using Tyuiu.SenachevAV.Sprint1.Task5.V1.Lib;
 
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Сеначев А.В. | АСОиУб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Class Math                                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУб-24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x2, x1,  y2, y1;


        Console.WriteLine("Введите значение x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение y2");
        y2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        int res = Convert.ToInt32(ds.DistanceBetweenDots(x2, x1, y2, y1));
        Console.WriteLine(res);

        Console.ReadLine();
    }
}