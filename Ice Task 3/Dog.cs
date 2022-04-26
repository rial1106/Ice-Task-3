using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    class Dog
    {

        enum FurType
        {
            SMOOTH, ROUGH
        }

        FurType furType;

        String dogBreed;

        private FurType FurType1 { get => furType; set => furType = value; }
        public string DogBreed { get => dogBreed; set => dogBreed = value; }
    }
}
