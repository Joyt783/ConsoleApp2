using ConsoleApp2;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Plus_4and2()
        {
            // Значення які будуть передані в метод
            int a = 4;
            int b = 2;
            //очікуваний результат
            int expected = 6;
            Plus_Subtraction object1 = new Plus_Subtraction();
            int actual = object1.Plus(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtraction_4and2()
        {
            // Значення які будуть передані в метод
            int a = 4;
            int b = 2;
            //очікуваний результат
            int expected = 2;
            Plus_Subtraction object2 = new Plus_Subtraction();
            int actual = object2.Subtraction(a, b);
            Assert.Equal(expected, actual);
        }

    }
}
