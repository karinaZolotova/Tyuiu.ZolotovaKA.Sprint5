using Tyuiu.ZolotovaKA.Sprint5.Task6.V28.Lib;
static void Main(string[] args)
{
    DataService ds = new DataService();

    Console.Title = "Спринт #5 | Выполнила: Золотова К.А | ИСПб-24-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Класс File. Запись данных в текстовый фай                         *");
    Console.WriteLine("* Задание #5                                                              *");
    Console.WriteLine("* Вариант #3                                                              *");
    Console.WriteLine("* Выполнила: Золотова К.А | ИСПб-24-1                                     *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    string path = @"C:\DataSprint5\InPutDataFileTask5V3.txt";
    Console.WriteLine("Данные находятся в файле:" + path);
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    double res = ds.LoadFromDataFile(path);
    Console.WriteLine(res);
    Console.ReadKey();
}
    
    
