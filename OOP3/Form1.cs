namespace OOP3
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 c2 = new Class2();
            //MessageBox.Show(c2.GetAAA().ToString());
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var f = new Form2())
            {
                f.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            base.SetStatusLabel("èàóùíÜ");
            base.SetProgress(50);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            base.SetStatusLabel("äÆóπ");
            base.SetProgress(100);
        }
    }
}
