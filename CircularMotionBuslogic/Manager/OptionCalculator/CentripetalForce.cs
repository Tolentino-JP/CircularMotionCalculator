using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularMotionModel.Model;


namespace CircularMotionBuslogic.Manager.OptionCalculator
{
    public class CentripetalForce
    {

        // computing centripetal force
        public double CentripetalForceCompute(Values _values)
        {
            return Math.Round((_values.mass * Math.Pow(_values.tangentialVelocity, 2) / _values.radius), 2);
        }


    }
}
