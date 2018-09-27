using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Square

    
    {

        public Square()
        {
            SetData();
        }

        private double heightWidth;

        public  void SetData()
        {
           double input;
            bool stop = false;
            while (!stop)
            {
                try
                {
                    Console.WriteLine("Please enter the Lenght of your Sqaures sides");
                    input = double.Parse(Console.ReadLine());
                    heightWidth = input;
                    stop = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a number");
                }catch(ArgumentNullException ne)
                {
                    
                }

            }
            }

        public  double CalculateArea()
        {
            return heightWidth * heightWidth; ;
        }
    }
}
