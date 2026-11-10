using Tyuiu.PeshkovFA.Sprint5.Task7.V9.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Fedor\source\repos\Tyuiu.PeshkovFA.Sprint5\Tyuiu.PeshkovFA.Sprint5.Task7.V9\bin\Debug\InPutDataFileTask7V9.txt";
            string pathSaveFile = ds.LoadDataAndSave(path);

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    
    }
}
