using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private async void button_Login_Click(object sender, EventArgs e)
        {
            var delayInMs = 5000;
            var authService = new AuthenticationService();
            var authTask = authService.AuthenticateAsync(textBox_Username.Text, textBox_Password.Text, delayInMs);

            Log($"Authenticating. This takes {delayInMs / 1000} seconds...");
            var authenticationResult = await authTask;

            if (authenticationResult)
            {
                MessageBox.Show(@"Login Success.");
            }
            else
            {
                MessageBox.Show(@"Access Denied.");
            }
        }


        private void PriceList_Load(object sender, EventArgs e)
        {

        }

        // 
        // Extra
        //

        private void Log(string message)
        {
            listBox_PriceList.Items.Add($"{DateTime.Now:HH:mm:ss} - {message}");

        }
    }
}
