using NLog;
using System;
using System.Threading;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Home : Form
    {
        private readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public Home()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MessageTextBox.Text))
            {
                return;
            }

            Logger.Info(MessageTextBox.Text);
        }

        private void UseThreadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MessageTextBox.Text))
            {
                return;
            }

            new Thread(() => Logger.Info(MessageTextBox.Text)).Start();
        }
    }
}
