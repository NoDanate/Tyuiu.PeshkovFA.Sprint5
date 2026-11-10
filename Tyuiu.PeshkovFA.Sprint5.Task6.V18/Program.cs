using Tyuiu.PeshkovFA.Sprint5.Task6.V18.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Fedor\source\repos\Tyuiu.PeshkovFA.Sprint5\Tyuiu.PeshkovFA.Sprint5.Task6.V18\bin\Debug\InPutDataFileTask6V18.txt";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine(" ***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
