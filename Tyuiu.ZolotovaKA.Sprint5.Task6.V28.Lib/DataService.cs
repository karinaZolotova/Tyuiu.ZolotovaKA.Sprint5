using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZolotovaKA.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";
            string fileContent = File.ReadAllText(path);
            MatchCollection nums = Regex.Matches(fileContent, @"\b\d{4}\b");
            return nums.Count;

          

        }
    }
}