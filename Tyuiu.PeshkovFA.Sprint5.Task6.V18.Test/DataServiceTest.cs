using Tyuiu.PeshkovFA.Sprint5.Task6.V18.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Fedor\source\repos\Tyuiu.PeshkovFA.Sprint5\Tyuiu.PeshkovFA.Sprint5.Task6.V18\bin\Debug\InPutDataFileTask6V18.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Fedor\source\repos\Tyuiu.PeshkovFA.Sprint5\Tyuiu.PeshkovFA.Sprint5.Task6.V18\bin\Debug\InPutDataFileTask6V18.txt";

            var res = ds.LoadFromDataFile(path);

            int wait = res;

            Assert.AreEqual(wait, res);
        }
    }
}
