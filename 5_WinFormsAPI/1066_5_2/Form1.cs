namespace _1066_5_2
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClickMe_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Clicked! At coord = " + x + "/" +  y + Environment.NewLine;
        }

        private void buttonClickMe_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}