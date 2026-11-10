using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PeshkovFA.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsDigit(line[i]))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
