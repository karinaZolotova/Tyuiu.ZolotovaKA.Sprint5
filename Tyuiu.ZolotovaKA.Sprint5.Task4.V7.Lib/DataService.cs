using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZolotovaKA.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            string pathTransfer = File.ReadAllText(path);
            double x = double.Parse(pathTransfer.Replace(".", ","));
            return Math.Round((4.26 * x) / (Math.Sin(x)), 3);
        }
    }
}