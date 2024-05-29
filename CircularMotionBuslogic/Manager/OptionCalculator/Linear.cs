using CircularMotionModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularMotionBuslogic.Manager.OptionCalculator
{
    public class Linear
    {
        // Computing Linear Velocity
        public double LinearCompute(Values _values)
        {
            return _values.tangentialVelocity;
        }

    }
}
