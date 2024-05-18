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

            _centripetalForce.Ewan();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void massInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radiusInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void velocityInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
