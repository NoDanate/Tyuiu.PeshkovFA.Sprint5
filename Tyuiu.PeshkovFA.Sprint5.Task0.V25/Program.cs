using Tyuiu.PeshkovFA.Sprint5.Task0.V25.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("x: " + x);

            string filePath = ds.SaveToFileTextData(x);
            string result = File.ReadAllText(filePath);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Файл: " + filePath);
            Console.WriteLine("Создан!");
            Console.WriteLine("Результат вычисления y: " + result);
        }
    }
}
