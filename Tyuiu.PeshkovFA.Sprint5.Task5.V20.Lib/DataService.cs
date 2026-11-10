using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PeshkovFA.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string item in numbers)
                    {
                        if (int.TryParse(item, out int val))
                        {
                            if (val >= -10 && val <= 10)
                            {
                                sum += val;
                                count++;
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                return 0;
            }

            return Math.Round(sum / count, 3);
        }
    }
}
