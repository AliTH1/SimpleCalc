using MathOperations;

namespace Calculator
{
    public partial class Form1 : Form
    {
        MathematicOperations mathematic_operations = new MathematicOperations();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            int number_1 = Convert.ToInt32(txtbox_number_1.Text);
            int number_2 = Convert.ToInt32(txtbox_number_2.Text);
            int addition_result = mathematic_operations.addition(number_1, number_2);
            lbl_result.Text = addition_result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number_1 = Convert.ToInt32(txtbox_number_1.Text);
            int number_2 = Convert.ToInt32(txtbox_number_2.Text);
            int subtraction_result = mathematic_operations.subtraction(number_1, number_2);
            lbl_result.Text = subtraction_result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number_1 = Convert.ToInt32(txtbox_number_1.Text);
            int number_2 = Convert.ToInt32(txtbox_number_2.Text);
            int multiply_result = mathematic_operations.multiply(number_1, number_2);
            lbl_result.Text = multiply_result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number_1 = Convert.ToDouble(txtbox_number_1.Text);
            double number_2 = Convert.ToDouble(txtbox_number_2.Text);
            double divide_result = mathematic_operations.divide(number_1, number_2);
            lbl_result.Text = divide_result.ToString();
        }
    }
}