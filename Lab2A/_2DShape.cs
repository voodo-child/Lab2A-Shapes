using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public abstract class _2DShape : Shape {


        public abstract override void SetData();


        public abstract override double CalculateArea();

        public override double CalculateVolume()
        {
            return 0;
        }

        


    }
    }


