using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox.WinFormsAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = await LoginAsync();
                button1.Text = result;
            }
            catch (Exception)
            {
                button1.Text = "Login failed";
            }
        }

        // Returning Task instead of void as it gives button1_click control of the exception.
        private async Task<string> LoginAsync()
        {
            var result = await Task.Run(() =>
            {
                Thread.Sleep(2000);

                return "Login successful!";
            });

            // Executed after the async operation above is completed.
            return result;
        }
    }
}
