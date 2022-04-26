using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    public class Pet
    {

        public enum EyeColor
        {
            Brown, Black, White, Gray, Green, Red
        }

        double tailLength;
        EyeColor eyeColor;
        double length;
        double weight;

        public double TailLength { get => tailLength; set => tailLength = value; }
        private EyeColor EyeColor1 { get => eyeColor; set => eyeColor = value; }
        public double Length { get => length; set => length = value; }
        public double Weight { get => weight; set => weight = value; }
    }
}
