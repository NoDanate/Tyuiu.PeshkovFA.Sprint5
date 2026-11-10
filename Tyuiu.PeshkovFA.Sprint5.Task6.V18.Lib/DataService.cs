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
                    string[] elements = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string item in elements)
                    {
                        string trimmed = item.Trim(',', '.', ';', ':', '!', '?');

                        if (trimmed.Length == 1 && char.IsDigit(trimmed[0]))
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
