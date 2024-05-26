using CircularMotionModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularMotionBuslogic.Manager.OptionCalculator
{
    public class Acceleration
    {

        public double AccelerationCompute(Values _values)
        {
            return Math.Round((Math.Pow(_values.tangentialVelocity, 2) / _values.radius), 2);
        }

    }
}
