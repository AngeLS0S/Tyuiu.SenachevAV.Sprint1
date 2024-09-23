using Tyuiu.SenachevAV.Sprint1.Task3.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Сеначев А.В. | АСОиУб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУб-24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double a = 0;
        double b = 0;
        double h = 0;


        Console.WriteLine("Введите сторону параллепипида a");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону параллепипида b");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите высоту параллепипида h");
        h = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Обьём параллелепипеда " + ds.ParallelepipedVolume(a, b, h));

        Console.ReadLine();
    }
}