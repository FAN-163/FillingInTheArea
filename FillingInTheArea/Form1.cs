using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillingInTheArea
{
    public partial class Form1 : Form
    {
        int countSteps = 50;
        double error = 0.05;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sideA = Convert.ToDouble(SideA.Text.Replace(".",","));
            double sideB = Convert.ToDouble(SideB.Text.Replace(".", ","));
            double sideSquare = Convert.ToDouble(SideSquare.Text.Replace(".", ","));
            double step = Convert.ToDouble(Step.Text.Replace(".", ","));

            for(int i = 0; i <= countSteps; i++)
            {
                double countSquareVertical = Math.Round(sideA / (sideSquare + step * i));
                double countSquareHorizontal = Math.Round(sideB / (sideSquare + step * i));


                if((sideA - error < countSquareVertical *(sideSquare + step * i) &&  sideA + error > countSquareVertical * (sideSquare + step * i)) && 
                   (sideB - error < countSquareHorizontal * (sideSquare + step * i) && sideB + error > countSquareHorizontal * (sideSquare + step * i)))
                {
                    double countSquare = countSquareVertical * countSquareHorizontal;
                    
                    CountSquaer.Text += $"{countSquare} квадратов со стороной {sideSquare + step * i} заполнят полностью данный прямоугольник {Environment.NewLine}";
                }
                else
                {
                    continue;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SideA.Text = "20";
            SideB.Text = "40";
            SideSquare.Text = "2";
            Step.Text = "0,5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CountSquaer.Clear();
        }
    }
}
