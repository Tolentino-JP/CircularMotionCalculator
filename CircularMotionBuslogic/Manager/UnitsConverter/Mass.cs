using CircularMotionBuslogic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularMotionBuslogic.Manager.UnitsConverter
{
    public class Mass : UnitConverter
    {

        public override double Convert(string unit, double given)
        {
            if (unit != "kg")
            {
                return Math.Round((given / 1000), 2);
            }
            else
            {
                return given;
            }

        }


    }
}
