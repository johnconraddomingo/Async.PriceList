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

        private void button_Login_Click(object sender, EventArgs e)
        {
            var authService = new AuthenticationService();
            var authenticationResult =   authService.Authenticate(textBox_Username.Text, textBox_Password.Text);

            authenticationResult.Wait();

            if (!authenticationResult.Result)
            {
                MessageBox.Show(@"Access Denied");
            }


        }
    }
}
