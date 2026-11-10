using Tyuiu.PeshkovFA.Sprint5.Task7.V9.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Path.GetTempFileName();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Строка из файла:");

            string path = @"C:\Users\Fedor\source\repos\Tyuiu.PeshkovFA.Sprint5\Tyuiu.PeshkovFA.Sprint5.Task7.V9\bin\Debug\InPutDataFileTask7V9.txt";
            string pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Полученные данные находятся в файле: {pathSaveFile}");
            Console.ReadKey();
        }
    }
}
