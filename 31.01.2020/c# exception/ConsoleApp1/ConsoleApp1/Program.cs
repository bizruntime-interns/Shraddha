using System;

namespace ConsoleApp1
{
    class DivNums
    {
        int result;

        DivNums()
        {
            result = 0;
        }
        public void division(int num1,int num2)
        {
            try
            {
                result = num1 / num2;
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("result:{0}", result);
            }
        }
        static void Main(string[] args)
        {
            DivNums d = new DivNums();
            d.division(25, 5);
            Console.ReadKey();
        }
    }

}