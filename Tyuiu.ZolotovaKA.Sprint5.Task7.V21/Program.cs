using Tyuiu.ZolotovaKA.Sprint5.Task7.V21.Lib;

namespace Tyuiu.ZolotovaKA.Sprint5.Task7V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Удалить все символы   *");
            Console.WriteLine("* из файла. Полученный результат сохранить в файл                         *");
            Console.WriteLine("* OutPutDataFileTask7V21.txt                                              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint5\DataSprint5\InPutDataFileTask7V21.txt";
            string pathsave = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint5\Tyuiu.ShadrinEA.Sprint5.Task7V21\bin\Debug\OutPutFileTask7V21.txt";


            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле:");
            pathsave = ds.LoadDataAndSave(path);
            Console.WriteLine(pathsave);

            Console.ReadKey();
        }
    }
}