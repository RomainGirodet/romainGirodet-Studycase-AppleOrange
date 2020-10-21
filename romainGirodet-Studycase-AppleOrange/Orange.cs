using System;
using System.Collections.Generic;
using System.Text;

namespace romainGirodet_Studycase_AppleOrange
{
    class Orange : Fruit
    {
        double cost;
        public double Cost_Orange
        {
            get { return this.cost; }
        }
        public Orange()
        {
            cost = 0.25;
        }
    }
}
