using Tyuiu.ZolotovaKA.Sprint5.Task5.V27.Lib;
namespace Tyuiu.ZolotovaKA.Sprint5.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(7.5, ds.LoadFromDataFile(Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V27.txt")));
        }
    }
}