using System;
using System.Windows.Forms;

namespace QuickLog
{
    public partial class Form1 : Form
    {
        private readonly NLog.ILogger logger;

        public Form1()
        {
            InitializeComponent();
            this.logger = NLog.LogManager.GetCurrentClassLogger();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void ProcessMessage()
        {
            var message = this.ui_newLog.Text;
            this.ui_newLog.Clear();
            this.logger.Info(message);
            this.ui_history.AppendText(message + "\r\n");
            this.ui_history.ScrollToCaret();
        }

        private void ui_newLog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessMessage();
            }
        }
    }
}
