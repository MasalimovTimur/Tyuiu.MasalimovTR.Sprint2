using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MasalimovTR.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = c == d | a <= b;
            res[1] = d == a & b < c;
            res[2] = d < c || a > b;
            res[3] = d == a && b <= c;
            res[4] = !res[0] ;
            res[5] = b > c ^ d <= a;  
            return res;
        }
    }
}
