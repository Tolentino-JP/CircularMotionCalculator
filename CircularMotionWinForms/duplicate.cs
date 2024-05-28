using CircularMotionBuslogic.Manager;
using CircularMotionBuslogic.Manager.OptionCalculator;
using CircularMotionBuslogic.Manager.UnitsConverter;
using CircularMotionModel.Model;
using System.Formats.Asn1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CircularMotionWinForms
{
    public partial class Duplicate : Form
    {
        Values _values = new Values();

        public Duplicate()
        {
            InitializeComponent();
        }

        // When the form is loaded the value of the combobox is start from the index zero
        private void Form1_Load(object sender, EventArgs e)
        {
            option.SelectedIndex = 0;
            massLabel.SelectedIndex = 0;
            radiusLabel.SelectedIndex = 0;
            tangentialLabel.SelectedIndex = 0;
            angularLabel.SelectedIndex = 0;
        }

        // When clear all button is clicked all the input textbox will clear
        private void submitBtn_Click(object sender, EventArgs e)
        {
            massInput.Text = "";
            radiusInput.Text = "";
            tangentialInput.Text = "";
            angularInput.Text = "";
            answer.Text = "";
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
            MassError.SetError(massLabel, "");
        }

        private void tangentialInput_TextChanged(object sender, EventArgs e)
        {
            TangentialError.SetError(tangentialLabel, "");
        }

        private void radiusInput_TextChanged(object sender, EventArgs e)
        {
            RadiusError.SetError(radiusLabel, "");
        }

        // A function where accepts only number on a textbox
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

        private void angularInput_TextChanged(object sender, EventArgs e)
        {
            AngularError.SetError(angularLabel, "");
        }

        // This function will solved what is on the option
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Mass _massUnit = new();
            Radius _radius = new();
            Tangential _tangential = new();
            Angular _angular = new();
            Acceleration _acceleration = new();
            CentripetalForce _centripetal = new();
            Linear _linear = new();

            int status1 = 5;
            // Check if there is an empty input and set an error message
            status1 = GetError(status1);


            // if status is greater than 4 then there is no empty input 
            if (status1 > 4)
            {
                _values.mass = _massUnit.Convert(massLabel.Text, Parsing(massInput.Text));
                _values.radius = _radius.Convert(radiusLabel.Text, Parsing(radiusInput.Text));
                _values.angularVelocity = _angular.Convert(tangentialLabel.Text, Parsing(tangentialInput.Text));
                _values.tangentialVelocity = _tangential.Convert(angularLabel.Text, Parsing(angularInput.Text));




                switch (option.Text)
                {
                    case "Centripetal Force":
                        answer.Text = _centripetal.CentripetalForceCompute(_values).ToString() + "  N";
                        break;
                    case "Acceleration":
                        answer.Text = _acceleration.AccelerationCompute(_values).ToString() + "  m/s"+ "\u00B2";
                        break;
                    case "Linear Velocity":
                        answer.Text = _linear.LinearCompute(_values).ToString() + "  m/s";
                        break;
                }
            }

        }

        // parsing to double
        private double Parsing(string given)
        {
            return double.Parse(given);
        }

        // display error if there is no input
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

        // Solved tangential value if there is angular and radius value to balance the value
        private void GetTangential()
        {
            if (angularInput.Text.Length > 0 && radiusInput.Text.Length > 0)
            {
                tangentialInput.Text = (Math.Round((Parsing(angularInput.Text) * Parsing(radiusInput.Text)), 2)).ToString();
            }
            else
            {
                tangentialInput.Text = "";
            }
        }

        private void GetAngular()
        {
            if (tangentialInput.Text.Length > 0 && radiusInput.Text.Length > 0)
            {
                angularInput.Text = (Math.Round((Parsing(tangentialInput.Text) / Parsing(radiusInput.Text)), 2)).ToString();
            }
            else
            {
                angularInput.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            answer.Text = "";
        }

        private void tangentialInput_KeyUp(object sender, KeyEventArgs e)
        {
            GetAngular();
        }

        private void angularInput_KeyUp(object sender, KeyEventArgs e)
        {
            GetTangential();
        }

        private void radiusInput_KeyUp(object sender, KeyEventArgs e)
        {
            GetTangential();
            GetAngular();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
