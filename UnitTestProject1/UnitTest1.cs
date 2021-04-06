using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Multiplication_4and2()
        {
            // �������� �� ������ ������� � �����
            int a = 4;
            int b = 2;
            //���������� ���������
            int expected = 8;
            Multiplecation_Division object1 = new Multiplecation_Division();
            int actual = object1.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_4and2()
        {
            // �������� �� ������ ������� � �����
            double a = 4;
            double b = 2;
            //���������� ���������
            double expected = 2;
            Multiplecation_Division object2 = new Multiplecation_Division();
            double actual = object2.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
    }

}

