namespace Print_numbers_from_one_to_ten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1 ; i <= 10 ; i++)
            {
                string sayi = i.ToString() + ".";
                comboBox1.Items.Add(sayi);
            }
            
        }
    }
}