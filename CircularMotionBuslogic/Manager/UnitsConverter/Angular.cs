using CircularMotionBuslogic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularMotionBuslogic.Manager.UnitsConverter
{
    public class Angular : UnitConverter
    {

        public override double Convert(string unit, double given)
        {

            if (unit != "rad/s")
            {
                return Math.Round((given / 9.5493), 2);
            }
            else
            {
                return given;
            }

        }

    }
}
