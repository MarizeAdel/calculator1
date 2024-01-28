namespace calculator1
{
    public partial class Form1 : Form
    {
        Double Result = 0;
        String Operation = "";
        bool isOperatorPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" || isOperatorPerformed)
            {
                ResultTextBox.Clear();
            }
            isOperatorPerformed=false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!ResultTextBox.Text.Contains("."))
                {
                    ResultTextBox.Text = ResultTextBox.Text + button.Text;
                }
            }
            else
                ResultTextBox.Text = ResultTextBox.Text + button.Text;

        }



        private void Operators(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Result != 0)
            {
                equal.PerformClick();
                Operation = button.Text;
                Result = double.Parse(ResultTextBox.Text);
                DisplayOP.Text = Result + " " + Operation;
                isOperatorPerformed = true;
            }
            else
            {
                Operation = button.Text;
                Result = double.Parse(ResultTextBox.Text);
                DisplayOP.Text = Result + " " + Operation;
                isOperatorPerformed = true;


            }
        }

        private void ClearButton(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            Result = 0;
            Operation = "";
        }

        private void EqualButton(object sender, EventArgs e)
        {

            switch (Char.Parse(Operation))
            {
                case '+':
                    ResultTextBox.Text= (Result + double.Parse(ResultTextBox.Text)).ToString();
                    break;
                case '-':
                    ResultTextBox.Text = (Result - double.Parse(ResultTextBox.Text)).ToString();
                    break;
                case '*':
                    ResultTextBox.Text = (Result * double.Parse(ResultTextBox.Text)).ToString();
                    break;
                case '/':
                    ResultTextBox.Text = (Result / double.Parse(ResultTextBox.Text)).ToString();
                    break;
                default:
                    break;

            }
            Result = Double.Parse(ResultTextBox.Text);
            DisplayOP.Text = "";
        }
    }
}
