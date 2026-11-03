using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PeshkovFA.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string strX1 = strX.Replace(".", ",");
            double dX = Convert.ToDouble(strX1);
            double res = 1.0 / Math.Cos(dX) + Math.Pow(dX, 3);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
