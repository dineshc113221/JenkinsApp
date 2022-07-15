using System;
using Maths;
namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMaths myMaths = new MyMaths();
        
            Console.WriteLine("Addition is "+ myMaths.Add(5, 6));
            Console.WriteLine("Mul is "+ myMaths.Mul(5, 6));

            Console.ReadLine();

        }
    }
}
