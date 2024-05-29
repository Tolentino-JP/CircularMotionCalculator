using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularMotionModel.Model
{

    // Store all the inputs from the user
    public class Values
    {

        public double radius {  get; set; }
        public double mass { get; set; }
        public double angularVelocity { get; set; }
        public double tangentialVelocity { get; set; }

    }
}
