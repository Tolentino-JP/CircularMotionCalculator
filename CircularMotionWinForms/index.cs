using CircularMotionBuslogic.Manager;

namespace CircularMotionWinForms
{
    public partial class index : Form
    {
        public CentripetalForce _centripetalForce = new();

        public index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

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
            GetAcceleration();
        }

        private void tangentialInput_TextChanged(object sender, EventArgs e)
        {
            GetMass();
            GetAcceleration();
        }

        private void radiusInput_TextChanged(object sender, EventArgs e)
        {
            GetMass();
            GetAcceleration();
            GetTangential();
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
                if ((sender as TextBox).Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void GetMass()
        {
            if (radiusInput.Text.Length > 0 && tangentialInput.Text.Length > 0 && centripetalInput.Text.Length > 0)
            {
                double _cf = double.Parse(centripetalInput.Text);
                double _r = double.Parse(radiusInput.Text);
                double _tv = double.Parse(tangentialInput.Text);
                massInput.Text = ((_cf * _r) / Math.Pow(_tv, 2)).ToString();
            }
            else
            {
                massInput.Text = "";
            }
        }

        private void GetAcceleration()
        {
            if (tangentialInput.Text.Length > 0 && radiusInput.Text.Length > 0)
            {
                double _r = double.Parse(radiusInput.Text);
                double _tv = double.Parse(tangentialInput.Text);

                accelerationInput.Text = (Math.Pow(_tv, 2) / _r).ToString();
            }
            else
            {
                accelerationInput.Text = "";
            }
        }

        private void GetTangential()
        {
            if (angularInput.Text.Length > 0 && radiusInput.Text.Length > 0)
            {
                tangentialInput.Text = (double.Parse(angularInput.Text) * double.Parse(radiusInput.Text)).ToString();
            }
            else
            {
                tangentialInput.Text = "";
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
            GetMass();
        }

        private void accelerationInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void angularInput_TextChanged(object sender, EventArgs e)
        {
            GetTangential();
        }
    }
}
