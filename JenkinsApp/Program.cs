using System;
using Maths;
namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMaths myMaths = new MyMaths();
            myMaths.Add(5, 6);
            myMaths.Mul(5, 6);

            Console.ReadLine();

        }
    }
}
