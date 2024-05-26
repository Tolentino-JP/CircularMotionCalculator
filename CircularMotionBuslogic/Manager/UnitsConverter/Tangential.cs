using CircularMotionBuslogic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularMotionBuslogic.Manager.UnitsConverter
{
    public class Tangential : UnitConverter
    {

        public override double Convert(string unit, double given)
        {

            if (unit != "m/s")
            {
                return Math.Round((given / 3.6), 2);
            }
            else
            {
                return given;
            }
            // end if statement 

        }

    }
}
