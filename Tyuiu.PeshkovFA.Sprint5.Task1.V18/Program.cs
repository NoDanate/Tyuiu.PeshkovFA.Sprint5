using Tyuiu.PeshkovFA.Sprint5.Task1.V18.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int start = -5, stop = 5;

            string res = ds.SaveToFileTextData(start, stop);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("|    x    |        F(X)         |");
            Console.WriteLine("---------------------------------");

            string[] lines = File.ReadAllLines(res);
            int curr = start;

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"| {curr,7:F1} | {lines[i],19:F2} |");
                curr++;
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"File: {res}");
            Console.WriteLine("Создан");

            Console.ReadKey();
        }
    }
}
