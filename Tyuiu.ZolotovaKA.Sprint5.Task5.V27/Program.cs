using Tyuiu.ZolotovaKA.Sprint5.Task5.V27.Lib;
public class Class1
{
    public static void Main()
    {
        DataService ds = new DataService();
        double result;

        Console.Title = "Task:5.5.v27| Золотова К.А. ИСПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнила: Золотова К.А. ИСПб-24-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:          *\n");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Исходные данные:                                                        *");
        Console.Write("*  = " + Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V27.txt") + "\n");
        string input = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V27.txt");

        Console.WriteLine("***************************************************************************");

        { //code
            result = ds.LoadFromDataFile(input);
        }
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"*  = {result}");
        Console.WriteLine("***************************************************************************");
        Console.ReadKey();
    }
}
