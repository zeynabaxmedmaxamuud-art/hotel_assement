namespace assemen_two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textdiscountAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttcalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double nights = double.Parse(textnumberofnightes.Text);
                double price = double.Parse(textpricepernight.Text);

                // Calculate room cost
                double cost = nights * price;

                // Calculate tax 10%
                double tax = cost * 0.10;

                // Calculate discount 5%
                double discount = cost * 0.05;

                // Calculate final total
                double total = cost + tax - discount;

                // Display results
                textservicetax.Text = tax.ToString("C2");
                textdiscountAmount.Text = discount.ToString("C2");
                texttotalAmount.Text = total.ToString("C2");

            }
            catch
            {
                MessageBox.Show("wax soo galisa lama oggla");



            }
        }

        private void texttotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpricepernight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
