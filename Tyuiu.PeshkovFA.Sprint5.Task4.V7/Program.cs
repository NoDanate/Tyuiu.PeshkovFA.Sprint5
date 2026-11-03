using Tyuiu.PeshkovFA.Sprint5.Task4.V7.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Fedor\source\repos\Tyuiu.PeshkovFA.Sprint5\Tyuiu.PeshkovFA.Sprint5.Task4.V7\bin\Debug\InPutDataFileTask4V7.txt";
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
