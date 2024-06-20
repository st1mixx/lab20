namespace lab20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1, x2, y2;

            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля для координат.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                x1 = double.Parse(textBox1.Text);
                y1 = double.Parse(textBox2.Text);
                x2 = double.Parse(textBox3.Text);
                y2 = double.Parse(textBox4.Text);

                
                double distance = CalculateDistance(x1, y1, x2, y2);

               
                label1.Text = $"Відстань між точками: {distance:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть числові значення в обидва поля для координат.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

    }
}
