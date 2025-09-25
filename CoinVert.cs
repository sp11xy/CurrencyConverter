using System.Text.Json;

namespace CurrencyConverter
{
    public partial class CoinVert : Form
    {
        public CoinVert()
        {
            InitializeComponent();
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

                waitTxt.Text = "Please wait, updating rates from server...";

                decimal wonRate = await GetRateAsync("KRW");
                decimal yenRate = await GetRateAsync("JPY");
                decimal yuanRate = await GetRateAsync("CNY");
                decimal customRate = 0;


                if (customTxtBox.Text.Length == 3 && !string.IsNullOrWhiteSpace(inputTxtBox.Text))
                {
                    try
                    {
                        customRate = await GetRateAsync(customTxtBox.Text);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Country Code! Please enter a 3-letter code");
                        inputTxtBox.Text = "";
                        customTxtBox.Text = "";
                        convertTxtBox.Text = "";
                        waitTxt.Text = "";
                        return;
                    }
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
                else if (rBtnYuan.Checked)
                {
                    decimal converted = euro * yuanRate;
                    convertTxtBox.Text = $" {converted.ToString("N2")} CNY";
                }
                else if (rBtnCustom.Checked)
                {
                    if (customRate != 0)
                    {
                        decimal converted = euro * customRate;
                        convertTxtBox.Text = $" {converted.ToString("N2")} {customTxtBox.Text}";
                    }
                    else
                    {
                        MessageBox.Show("Problem occured, please try again!");
                        inputTxtBox.Text = "";
                        customTxtBox.Text = "";
                        convertTxtBox.Text = "";
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please only enter valid digits!");
                inputTxtBox.Text = "";
                customTxtBox.Text = "";
                convertTxtBox.Text = "";
                waitTxt.Text = "";
                return;
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


        private void CustomTxtBox_TextChanged(object sender, EventArgs e)
        {
            customTxtBox.CharacterCasing = CharacterCasing.Upper;
            customTxtBox.MaxLength = 3;

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supported Currencies:\n\n EUR, AED, AFN, ALL, AMD, ANG, AOA, ARS, AUD, AWG, AZN, BAM, BBD, BDT, BGN, BHD, BIF, BMD, BND, BOB, BRL, BSD, BTN, BWP, BYN, BZD, CAD, CDF, CHF, CLP, CNY, COP, CRC, CUP, CVE, CZK, DJF, DKK, DOP, DZD, EGP, ERN, ETB, FJD, FKP, FOK, GBP, GEL, GGP, GHS, GIP, GMD, GNF, GTQ, GYD, HKD, HNL, HRK, HTG, HUF, IDR, ILS, IMP, INR, IQD, IRR, ISK, JEP, JMD, JOD, JPY, KES, KGS, KHR, KID, KMF, KRW, KWD, KYD, KZT, LAK, LBP, LKR, LRD, LSL, LYD, MAD, MDL, MGA, MKD, MMK, MNT, MOP, MRU, MUR, MVR, MWK, MXN, MYR, MZN, NAD, NGN, NIO, NOK, NPR, NZD, OMR, PAB, PEN, PGK, PHP, PKR, PLN, PYG, QAR, RON, RSD, RUB, RWF, SAR, SBD, SCR, SDG, SEK, SGD, SHP, SLE, SLL, SOS, SRD, SSP, STN, SYP, SZL, THB, TJS, TMT, TND, TOP, TRY, TTD, TVD, TWD, TZS, UAH, UGX, USD, UYU, UZS, VES, VND, VUV, WST, XAF, XCD, XCG, XDR, XOF, XPF, YER, ZAR, ZMW, ZWL");
        }
    }
}
