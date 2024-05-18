using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularMotionModel.Model;


namespace CircularMotionBuslogic.Manager
{
    public class CentripetalForce
    {


        // computing centripetal force
        public double CentripetalForceCompute(Values _values)
        {

            double answer = (_values.mass * Math.Pow(_values.tangentialVelocity, 2) ) / _values.radius;

            return answer;
        }

        public void Ewan()
        {
            Console.WriteLine("Main Conneted Wow Pakyu melan");
        }

    }
}
