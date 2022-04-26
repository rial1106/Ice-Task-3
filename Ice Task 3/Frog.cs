using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    class Frog : Pet
    {

        double leapHeight;
        double numberOfWarts;

        public double LeapHeight { get => leapHeight; set => leapHeight = value; }
        public double NumberOfWarts { get => numberOfWarts; set => numberOfWarts = value; }
    }
}
