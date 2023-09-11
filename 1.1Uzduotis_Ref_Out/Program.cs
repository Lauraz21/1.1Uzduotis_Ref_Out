using System.Security.Cryptography.X509Certificates;

namespace _1._1Uzduotis_Ref_Out
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 5;
            int y = 2;
           
            IncrementByN(ref x, ref y);
            Console.WriteLine(x);
        }
        public static void IncrementByN(ref int x, ref int y)

        {
            x += y;   
        }
    }
}