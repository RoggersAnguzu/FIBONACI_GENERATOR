using System;
namespace FIBONACI
{
    public class Program
    {
        static void Main(string[] args)
        {
            MasterCaller();
        }
        public static int Recurse(int fibobacci)
        {
            if(fibobacci<=1)
            {
                return fibobacci;
            }
            else
            {
                return (fibobacci - 1) + (fibobacci - 2);
            }
        }
        public static  void MasterCaller()
        {
            Console.WriteLine("Kindly Enter the range of the fibonaci numbers to be entered: ");
            int Fib = int.Parse(Console.ReadLine());

            for(int i =0;i<Fib;i++)
            {
                Console.WriteLine(Recurse(i));
            }
            Console.WriteLine("Congratulations Your numbers are finished: ");
        }
    }
}