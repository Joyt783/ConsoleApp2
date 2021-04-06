using System;

namespace ConsoleApp2
{
    public class Plus_Subtraction
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
    public class Multiplecation_Division
    {
        public double Division(double a, double b)
        {
            return a / b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Multiplecation_Division obj1 = new Multiplecation_Division();
            Plus_Subtraction obj2 = new Plus_Subtraction();
            Console.WriteLine(obj1.Division(4, 2));
            Console.WriteLine(obj2.Plus(4, 2));
            Console.WriteLine(obj1.Multiplication(4, 2));
            Console.WriteLine(obj2.Subtraction(4, 2));
        }
    }
}
