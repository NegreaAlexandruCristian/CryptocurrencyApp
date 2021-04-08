using System;
using System.Windows.Forms;

namespace CryptocurrencyApp
{
    public partial class Form1 : Form
    {
        private dynamic[] coins;
        public Form1()
        {
            InitializeComponent();
            MoveSidePanel(dashboardButton);
            API api = new API();
            coins = api.getNeededCoins();
        }

        private void reset()
        {
            // This resets the buttons
            bitcoinButton.BackColor = System.Drawing.Color.White;
            cardanoButton.BackColor = System.Drawing.Color.White;
            dogecoinButton.BackColor = System.Drawing.Color.White;
            ethereumButton.BackColor = System.Drawing.Color.White;
            iotaButton.BackColor = System.Drawing.Color.White;
            litecoinButton.BackColor = System.Drawing.Color.White;
            moneroButton.BackColor = System.Drawing.Color.White;
            neoButton.BackColor = System.Drawing.Color.White;
            stellarButton.BackColor = System.Drawing.Color.White;

            //This resets the labels and textboxes
            purchaseLabelCoin.Text = "Purchase Coins : ";
            calulcatedFullPriceTextBox.Text = "";
            dollarTextBox.Text = "";
            coinPriceLabel.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ih(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void MoveSidePanel(Control control)
        {
            sidePanel.Height = control.Height;
            sidePanel.Top = control.Top;
        }
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(dashboardButton);
            purchasePanel.Visible = true;
            cryptocurrencyPanel.Visible = true;
            payPanel.Visible = true;
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(dataButton);
            purchasePanel.Visible = false;
            cryptocurrencyPanel.Visible = false;
            payPanel.Visible = false;

        }


        private void calculatePriceButton_Click(object sender, EventArgs e)
        {
            if (String.Equals(dollarTextBox.Text.Trim(), ""))
            {
                MessageBox.Show("Input a value", "Error");
                return;
            }

            if(String.Equals(coinPriceLabel.Text, "Coin Price : "))
            {
                MessageBox.Show("Please select a coin first!", "Error");
                return;
            }

            double price = Double.Parse(coinPriceLabel.Text.Substring(14));
            double inputValue = Double.Parse(dollarTextBox.Text);
            calulcatedFullPriceTextBox.Text = " $" + Math.Round((price * inputValue),2);
        }

        private void bitcoinButton_Click(object sender, EventArgs e)
        {
            reset();
            bitcoinButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[0]["name"] + " : ";
            double price = coins[0]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price, 2);
        }

        private void ethereumButton_Click(object sender, EventArgs e)
        {
            reset();
            ethereumButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[1]["name"] + " : ";
            double price = coins[1]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price,2);
        }

        private void stellarButton_Click(object sender, EventArgs e)
        {
            reset();
            stellarButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[6]["name"] + " : ";
            double price = coins[6]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price, 2);
        }

        private void litecoinButton_Click(object sender, EventArgs e)
        {
            reset();
            litecoinButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[2]["name"] + " : ";
            double price = coins[2]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price, 2);
        }

        private void cardanoButton_Click(object sender, EventArgs e)
        {
            reset();
            cardanoButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[5]["name"] + " : ";
            double price = coins[5]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price, 2);
        }

        private void iotaButton_Click(object sender, EventArgs e)
        {
            reset();
            iotaButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[3]["name"] + " : ";
            double price = coins[3]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price, 2);
        }

        private void moneroButton_Click(object sender, EventArgs e)
        {
            reset();
            moneroButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[7]["name"] + " : ";
            double price = coins[7]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price, 2);
        }

        private void neoButton_Click(object sender, EventArgs e)
        {
            reset();
            neoButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[4]["name"] + " : ";
            double price = coins[4]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price, 2);
        }

        private void dogecoinButton_Click(object sender, EventArgs e)
        {
            reset();
            dogecoinButton.BackColor = System.Drawing.Color.Blue;
            purchaseLabelCoin.Text = "Purchase " + coins[8]["name"] + " : ";
            double price = coins[8]["quote"]["USD"]["price"];
            coinPriceLabel.Text = "Coin Price : $ " + Math.Round(price, 2);
        }
    }
}
