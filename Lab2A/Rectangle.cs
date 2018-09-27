using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Rectangle:_2DShape
    {

        private double height;
        private double width;

        public Rectangle()
        {
            SetData();
        }


        public override void SetData()
        {
            double inputHeight = double.Parse(Console.ReadLine());
            double inputWidth = double.Parse(Console.ReadLine());
            height = inputHeight;
            width = inputWidth;
        }

        public override double CalculateArea()
        {
            return height * width;
        }



    }
}
