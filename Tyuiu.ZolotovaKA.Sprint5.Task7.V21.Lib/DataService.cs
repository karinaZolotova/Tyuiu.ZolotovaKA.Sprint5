using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZolotovaKA.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pathsave = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint5\Tyuiu.ShadrinEA.Sprint5.Task7V21\bin\Debug\OutPutFileTask7V21.txt";
            FileInfo fi = new FileInfo(pathsave);
            bool fileExists = fi.Exists;
            if (fileExists)
            {
                File.Delete(pathsave);
            }

            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != '.' && line[i] != ',' && line[i] != '!' && line[i] != '?' && line[i] != ':' && line[i] != ';' && line[i] != '/' && line[i] != '-')
                        {
                            strline = strline + line[i];
                        }
                    }
                }
                File.AppendAllText(pathsave, strline + Environment.NewLine);
                strline = "";


            }
            return pathsave;
        }
    }
}