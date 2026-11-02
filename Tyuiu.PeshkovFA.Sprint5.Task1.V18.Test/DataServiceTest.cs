using Tyuiu.PeshkovFA.Sprint5.Task1.V18.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int startValue = -5, endValue = 5;
            string path = ds.SaveToFileTextData(startValue, endValue);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
