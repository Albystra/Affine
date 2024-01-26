using NUnit.Framework;
using System;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ebutton_Click()
        {
            Random random = new Random();
            int delay = random.Next(10, 50); // ��������� ��������� �������� �� 100 �� 1000 �����������
            System.Threading.Thread.Sleep(delay); // �������� ���������� �����
            Console.WriteLine("Test1 executed with delay: " + delay + " milliseconds.");
        }
    }
}