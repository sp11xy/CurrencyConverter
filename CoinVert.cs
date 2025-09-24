namespace CurrencyConverter
{
    public partial class CoinVert : Form
    {
        public CoinVert()
        {
            InitializeComponent();
        }

        private void RbtnYen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RbtnWon_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Convert_Click(object sender, EventArgs e)
        {
            decimal wonRate = 1450.50m;
            decimal yenRate = 160.20m;
            decimal yuanRate = 60.23m;
            //decimal euro = decimal.Parse(inputTxtBox.Text); //dangerous cuz it gets easily parse errors
            decimal euro;
            if (decimal.TryParse(inputTxtBox.Text, out euro))
            {
                if (rBtnWon.Checked)
                {
                    decimal converted = euro * wonRate;
                    convertTxtBox.Text = converted.ToString("N2"); //2 Decimal places, best for money
                }
                else if (rBtnYen.Checked)
                {
                    decimal converted = euro * yenRate;
                    convertTxtBox.Text = converted.ToString("N2");
                }

            }
            else
            {
                MessageBox.Show("Please only enter valid digits!");
            }



        }

        private void Reset_Click(object sender, EventArgs e)
        {
            inputTxtBox.Text = "";
            convertTxtBox.Text = "";
            rBtnWon.Checked = true;
            inputTxtBox.Focus();
        }


        private void rBtnYuan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
