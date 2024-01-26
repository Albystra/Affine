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
            int delay = random.Next(10, 50); // Генерация случайной задержки от 100 до 1000 миллисекунд
            System.Threading.Thread.Sleep(delay); // Задержка выполнения теста
            Console.WriteLine("Test1 executed with delay: " + delay + " milliseconds.");
        }
    }
}