namespace RandomSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random RandomSayi = new Random();
            int sayi = RandomSayi.Next(0, 10); //0 dan 9 a kadar üretilir.
            label2.Text = sayi.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}