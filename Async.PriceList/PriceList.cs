using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Async.ThirdParty;

namespace Async.PriceList
{
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }

        // Need *async* here
        private async void button_Login_Click(object sender, EventArgs e)
        {
            var delayInMs = 5000;
            var authService = new AuthenticationService();
            var authTask = authService.AuthenticateAsync(textBox_Username.Text, textBox_Password.Text, delayInMs);

            // We've already called the Authenticate method
            // You can do whatever here. We'll just log

            Log($"Authenticating. This takes {delayInMs / 1000} seconds...");
            var authenticationResult = await authTask;

            if (authenticationResult)
            {
                MessageBox.Show(@"Login Success.");
                // Now, populate

                var pricesService = new PriceListSource();
                var priceTask = pricesService.GetPricesAsync();

                // Again, you can do whatever here. We'll just log.
                // In reality, you'd want to show a "Loading" gif, set your buttons to disabled and enable
                // them again when you're done.

                Log("Getting prices. This might take a while...");
                var result = await priceTask ;
                Log("After the await line, we're back in control!");
                ShowPrices(result);

                Log("Done.");
            }
            else
            {
                MessageBox.Show(@"Access Denied.");
                // Do Nothing
            }
        }

        // 
        // Extra
        //

        // We're in the UI Thread. Not asynchronous jobs

        private void Log(string message)
        {
            textBox_Logs.AppendText($"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
        }

        private void ShowPrices(List<string> prices)
        {
            listBox_PriceList.DataSource = prices;
        }
    }
}
