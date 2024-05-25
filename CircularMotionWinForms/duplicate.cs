using CircularMotionBuslogic.Manager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CircularMotionWinForms
{
    public partial class Duplicate : Form
    {
        public CentripetalForce _centripetalForce = new();

        public Duplicate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            option.SelectedIndex = 0;
            massLabel.SelectedIndex = 0;
            radiusLabel.SelectedIndex = 0;
            tangentialLabel.SelectedIndex = 0;
            angularLabel.SelectedIndex = 0;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            massInput.Text = "";
            radiusInput.Text = "";
            tangentialInput.Text = "";
            angularInput.Text = "";
            answer.Text = "";
            /*velocityInput.Text = "";
            accelerationInput.Text = "";*/

        }

        private void massInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void radiusInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void massInput_TextChanged(object sender, EventArgs e)
        {
            /*GetAcceleration();
            GetCentripetal();
            GetRadius();*/
            MassError.SetError(massLabel, "");

        }

        private void tangentialInput_TextChanged(object sender, EventArgs e)
        {
            /*GetMass();
            GetAcceleration();
            GetCentripetal();
            GetRadius();*/
            TangentialError.SetError(tangentialLabel, "");

        }

        private void radiusInput_TextChanged(object sender, EventArgs e)
        {
            /*GetMass();
            GetAcceleration();
            GetTangential();
            GetCentripetal();*/
            RadiusError.SetError(radiusLabel, "");
        }


        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, the Backspace key, and one decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Check if the key pressed is a decimal point
            if (e.KeyChar == '.')
            {
                // If there's already a decimal point in the text, handle the event to ignore the input
                if ((sender as System.Windows.Forms.TextBox).Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void GetMass()
        {
            if (radiusInput.Text.Length > 0 && tangentialInput.Text.Length > 0 && answer.Text.Length > 0)
            {
                double _cf = double.Parse(answer.Text);
                double _r = double.Parse(radiusInput.Text);
                double _tv = double.Parse(tangentialInput.Text);
                massInput.Text = (Math.Round(((_cf * _r) / Math.Pow(_tv, 2)), 2)).ToString();
            }
            /*else
            {
                massInput.Text = "";
            }*/
        }

        private void GetAcceleration()
        {

            if (answer.Text.Length > 0 && massInput.Text.Length > 0 && tangentialInput.Text.Length > 0)
            {
                double _cf = double.Parse(answer.Text);
                double _mass = double.Parse(massInput.Text);
                double _tv = double.Parse(tangentialInput.Text);

                //accelerationInput.Text = (Math.Round(((_mass * Math.Pow(_tv, 2)) / _cf), 2)).ToString();
            }
            else if (tangentialInput.Text.Length > 0 && radiusInput.Text.Length > 0)
            {
                double _r = double.Parse(radiusInput.Text);
                double _tv = double.Parse(tangentialInput.Text);

                //accelerationInput.Text = (Math.Round((Math.Pow(_tv, 2) / _r), 2)).ToString();
            }
            else
            {
                //accelerationInput.Text = "";
            }
        }

        private void GetTangential()
        {
            if (massInput.Text.Length > 0 && radiusInput.Text.Length > 0 && answer.Text.Length > 0)
            {
                double _mass = double.Parse(massInput.Text);
                double _radius = double.Parse(radiusInput.Text);
                double _centripetal = double.Parse(answer.Text);

                tangentialInput.Text = (Math.Sqrt((_centripetal * _radius) / _mass)).ToString();
            }
            else if (angularInput.Text.Length > 0 && radiusInput.Text.Length > 0)
            {
                tangentialInput.Text = (Math.Round(double.Parse(angularInput.Text) * double.Parse(radiusInput.Text), 2)).ToString();

            }
            else
            {
                tangentialInput.Text = "";
            }
        }

        private void GetCentripetal()
        {


            if (massInput.Text.Length > 0 && tangentialInput.Text.Length > 0 && radiusInput.Text.Length > 0)
            {
                double _mass = double.Parse(massInput.Text);
                double _tangential = double.Parse(tangentialInput.Text);
                double _radius = double.Parse(radiusInput.Text);

                answer.Text = (Math.Round(((_mass * Math.Pow(_tangential, 2)) / _radius), 2)).ToString();

            }
            else
            {
                answer.Text = "";
            }

        }

        private void GetRadius()
        {

            if (massInput.Text.Length > 0 && tangentialInput.Text.Length > 0 && answer.Text.Length > 0)
            {
                double _mass = double.Parse(massInput.Text);
                double _tv = double.Parse(tangentialInput.Text);
                double _cf = double.Parse(answer.Text);
                radiusInput.Text = (Math.Round(((_mass * Math.Pow(_tv, 2)) / _cf), 2)).ToString();

            }

        }

        private void velocityInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tangentialInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void angularInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void centripetalInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void velocityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void accelerationInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnly(sender, e);
        }

        private void centripetalInput_TextChanged(object sender, EventArgs e)
        {
            /*GetMass();
            GetRadius();*/

        }

        private void accelerationInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void angularInput_TextChanged(object sender, EventArgs e)
        {
            /*GetTangential();*/
            AngularError.SetError(angularLabel, "");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int status1 = 5;
            
            status1 = GetError(status1);

            

            if(status1 >4)
            {
                double mass = MassUnit(massLabel.Text, double.Parse(massInput.Text));
                double radius = RadiusUnit(radiusLabel.Text, )


                switch (option.Text)
                {
                    case "Centripetal Force":
                        answer.Text = (Math.Round((mass * Math.Pow(tangential, 2) / radius), 2)).ToString() + " N";
                        break;
                    case "Acceleration":
                        break;
                    case "Linear Velocity":
                        break;
                }
            }

        }
        
        private double Parsing(string given)
        {
            return double.Parse(given);
        }

        private int GetError(int status)
        {
            if (string.IsNullOrEmpty(massInput.Text.Trim()))
            {
                MassError.SetError(massLabel, "Mass is Required");
                status--;
            }
            if (string.IsNullOrEmpty(radiusInput.Text.Trim()))
            {
                RadiusError.SetError(radiusLabel, "Radius is Required");
                status--;
            }
            if (string.IsNullOrEmpty(tangentialInput.Text.Trim()))
            {
                TangentialError.SetError(tangentialLabel, "Tangential Velocity is Required");
                status--;
            }
            if (string.IsNullOrEmpty(angularInput.Text.Trim()))
            {
                AngularError.SetError(angularLabel, "Angular Velocity is Required");
                status--;
            }

            return status;
        }

        private double MassUnit(string mass, double given)
        {
            if(mass != "kg")
            {
                return given * ( 1 / 1000);
            }
            else
            {
                return given;
            }
        }

        private double RadiusUnit()
        {

            if()



            return 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
