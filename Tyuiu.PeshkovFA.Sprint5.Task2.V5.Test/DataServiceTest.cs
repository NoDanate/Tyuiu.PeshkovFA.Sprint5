using Tyuiu.PeshkovFA.Sprint5.Task2.V5.Lib;

namespace Tyuiu.PeshkovFA.Sprint5.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 9, 6, 6 },
                { 8, 7, 2 },
                { 1, 7, 8 }
            };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 9, 6, 6 },
                { 8, 7, 2 },
                { 1, 7, 8 }
            };

            string path = ds.SaveToFileTextData(matrix);

            string fileData = File.ReadAllText(path);
            string wait = "0;6;6" + Environment.NewLine + "8;0;2" + Environment.NewLine + "0;0;8";

            Assert.AreEqual(wait, fileData);
        }
    }
}
