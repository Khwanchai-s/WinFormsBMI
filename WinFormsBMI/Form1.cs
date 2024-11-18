namespace WinFormsBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double weight = Convert.ToDouble(textBox1.Text);
            //double height = Convert.ToDouble(textBox2.Text);
            double weight = 0; 
            double height = 0;
            if (double.TryParse(textBox1.Text, out weight)==false)
            {
                textBox1.Text = "0";
                return;             // �������
            }
            if (!double.TryParse(textBox2.Text, out height))
            {
                textBox2.Text = "0";
                return;             // �������
            }
            //Process �ӹǳ BMI
            double bmi = weight / Math.Pow(height / 100, 2);
            string result = "";
            if (bmi < 18.5)
            {
                result = "Underweight";
            }
            else if (bmi < 25.0)
            {
                result = "Normal weight";
            }
            else if (bmi < 30)
            {
                result = "Overweight";
            }
            else
            {
                result = "obesity";
            }
            label3.Text = "Your Body mass index (BMI) is " + bmi.ToString("0.00");
            label4.Text = "From your body mass index, you are " + result;
        }
    }
}
