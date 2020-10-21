using System;
using System.Collections.Generic;
using System.Text;

namespace romainGirodet_Studycase_AppleOrange
{
    class Shop
    {
        List<Fruit> listeFruit = new List<Fruit>();
        public Shop(List<Fruit> listeFruit)
        {
            this.listeFruit = listeFruit;
        }

        public void createRandomFruit(int numberOfFruit)
        {
            for (int i = 0; i < numberOfFruit; i++)
            {
                Random rdm = new Random();

                Apple apple = new Apple();
                Orange orange = new Orange();

                if (rdm.Next(1, 3) == 1)
                {
                    listeFruit.Add(apple);
                }
                else
                {
                    listeFruit.Add(orange);
                }
            }
        }
        public double TotalCost()
        {
            double totalCost = 0;

            for (int i = 0; i < listeFruit.Count; i++)
            {
                totalCost += listeFruit[i].Cost;
            }

            return totalCost;
        }

    }
}
