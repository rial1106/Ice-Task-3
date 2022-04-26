using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_Task_3
{
    public partial class Form1 : Form
    {

        enum PetTypes
        {
            Dog, Cat, Snake, Bird, Frog
        }

        public Form1()
        {
            InitializeComponent();
            PetChoiceComboBox.DataSource = Enum.GetNames(typeof(PetTypes));
            comboBox3.DataSource = Enum.GetNames(typeof(Pet.EyeColor));
        }


        private void PetChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch(PetChoiceComboBox.SelectedIndex)
            {
                case 0:
                    makeDog();
                    break;
               /* case 1:
                    makeCat();
                    break;
                case 2:
                    makeSnake();
                    break;
                case 3:
                    makeBird();
                    break;
                case 4:
                    makeFrog();
                    break;*/
                default:
                    label1.Text = "Broken";
                    break;
            }
           
        }


        void makeDog()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
