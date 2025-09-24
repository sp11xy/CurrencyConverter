using System.Text.Json;

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

        private async Task<decimal> GetRateAsync(string currency)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.exchangerate-api.com/v4/latest/EUR";

            string json = await client.GetStringAsync(url); //await -> waits till the server response

            using JsonDocument doc = JsonDocument.Parse(json); //parse to json

            decimal rate = doc.RootElement.GetProperty("rates").GetProperty(currency).GetDecimal();
            
            return rate;
        }


        private async void Convert_Click(object sender, EventArgs e)
        {
            waitTxt.Text = "fetching newest rates from the server...";


            decimal wonRate = await GetRateAsync("KRW");
            decimal yenRate = await GetRateAsync("JPY");
            decimal yuanRate = await GetRateAsync("CNY");


            //decimal euro = decimal.Parse(inputTxtBox.Text); //dangerous cuz it gets easily parse errors
            decimal euro;
            if (decimal.TryParse(inputTxtBox.Text, out euro))
            {
                if (euro < 0)
                {
                    MessageBox.Show("Please only positiv Values!");
                    inputTxtBox.Text = "";
                    return;
                }


                if (rBtnWon.Checked)
                {
                    decimal converted = euro * wonRate;
                    convertTxtBox.Text = $" {converted.ToString("N2")} WON"; //2 Decimal places, best for money
                }
                else if (rBtnYen.Checked)
                {
                    decimal converted = euro * yenRate;
                    convertTxtBox.Text = $" {converted.ToString("N2")} JPY";
                }
                else if(rBtnYuan.Checked)
                {
                    decimal converted = euro * yuanRate;
                    convertTxtBox.Text = $" {converted.ToString("N2")} CNY";
                }

            }
            else
            {
                MessageBox.Show("Please only enter valid digits!");
            }

            waitTxt.Text = "";

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
