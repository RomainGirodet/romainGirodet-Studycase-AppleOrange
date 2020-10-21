using System;

namespace romainGirodet_Studycase_AppleOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> listeFruitTest = new List<Fruit>();
            Shop shopTest = new Shop(listeFruitTest);
            shopTest.createRandomFruit(10);

            double Total = shopTest.TotalCost();
            Console.WriteLine(Total);

            Console.ReadKey();
        }
    }
}
