using Tyuiu.PeshkovFA.Sprint5.Task0.V25.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile() {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
