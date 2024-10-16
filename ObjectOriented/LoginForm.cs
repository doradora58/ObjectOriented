namespace ObjectOriented
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            var val = GetAmount();
            ShowLabel.Text = (val * 1.10m).ToString() + "‰~";
        }

        private decimal GetAmount()
        {
            return 100m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var money = new Money(GetAmount());
            ShowLabel.Text = money.TaxValue + "‰~";
        }

        private void ExecutionButton_Click(object sender, EventArgs e)
        {
            // Silver 0%
            // Gold 20%
            //Pratinum 40%
            if (SilverRadioButton.Checked)
            {
                LoginInfo.Member = new SilverMember();
            }
            if (GoldRadioButton.Checked)
            {
                LoginInfo.Member = new GoldMember();
            }
            if (PlatinumRadioButton.Checked)
            {
                LoginInfo.Member = new PlatinumMember();
            }
            using (var f = new Form1())
            {
                f.ShowDialog();
            }
        }


    }
}
