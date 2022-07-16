namespace Radius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pi = 3.14F;
            float radius;
            radius = Convert.ToInt32(textBox1.Text);
            float environment, area, diameter;
            environment = 2 * pi * radius;
            area = pi * radius * radius;
            diameter = radius * 2;
            txtRes.Text = "Environment: " + environment.ToString() + "   ,   " + "Area: " + area.ToString() + "   ,   " + "Diameter: " + diameter.ToString();
        }
    }
}