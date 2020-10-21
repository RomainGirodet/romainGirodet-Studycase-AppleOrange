using System;
using System.Collections.Generic;
using System.Text;

namespace romainGirodet_Studycase_AppleOrange
{
    class Apple : Fruit
    {
        double cost;

        public double Cost_Apple
        {
            get { return this.cost; }
        }


        public Apple()
        {
            cost = 0.60;
        }
    }
}
