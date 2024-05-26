using CircularMotionBuslogic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularMotionBuslogic.Manager.UnitsConverter
{
    public class Radius : UnitConverter
    {

        public override double Convert(string unit, double given)
        {

            if (unit != "m")
            {
                double answer = 0;

                switch (unit)
                {
                    case "cm":
                        answer = Math.Round((given / 100), 2);
                        break;
                    case "km":
                        answer = Math.Round((given * 1000), 2);
                        break;
                    case "in":
                        answer = Math.Round((given / 39.3701), 2);
                        break;
                }
                return answer;
            }
            else
            {
                return given;
            }
            // end if statement


        }

    }
}
