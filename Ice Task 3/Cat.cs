using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    class Cat : Pet
    {

        double whiskerLength;
        double pawSize;

        public double WhiskerLength { get => whiskerLength; set => whiskerLength = value; }
        public double PawSize { get => pawSize; set => pawSize = value; }
    }
}
