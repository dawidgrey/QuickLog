using System;
using System.IO;
using System.Windows.Forms;
using NLog;
using NLog.Targets;

namespace QuickLog
{
    public partial class Form1 : Form
    {
        private readonly NLog.ILogger logger;

        private bool canClose = false;

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

            if(!this.canClose)
                e.Cancel = true;
        }

        private void ProcessMessage()
        {
            var message = this.ui_newLog.Text;



            this.ui_newLog.Clear();
            this.logger.Info(message);
            this.ui_history.AppendText(message + "\r\n");
            this.ui_history.ScrollToCaret();


            if (message.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
            {
                this.canClose = true;
                this.Close();
            }
        }

        private void ui_newLog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessMessage();
            }
        }

        private void ui_newLog_DoubleClick(object sender, EventArgs e)
        {
            var fileTarget = (FileTarget) LogManager.Configuration.FindTargetByName("file");
            var logEventInfo = new LogEventInfo {TimeStamp = DateTime.Now};
            string fileName = fileTarget.FileName.Render(logEventInfo);
            var folder = Path.GetDirectoryName(fileName);

            if(System.IO.Directory.Exists(folder))
            {
                System.Diagnostics.Process.Start("explorer.exe", folder);
            }
        }

        private void ui_history_Enter(object sender, EventArgs e)
        {
            this.ui_newLog.Focus();
        }
    }
}
