using Tyuiu.MasalimovTR.Sprint2.Task1.V3.Lib;

namespace Tyuiu.MasalimovTR.Sprint2.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait= new bool[6] {true, false, false, false, false, false};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}