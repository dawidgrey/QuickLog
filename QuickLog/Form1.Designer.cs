namespace QuickLog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ui_newLog = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ui_history = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ui_newLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 19);
            this.panel1.TabIndex = 0;
            // 
            // ui_newLog
            // 
            this.ui_newLog.BackColor = System.Drawing.Color.Gray;
            this.ui_newLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ui_newLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_newLog.ForeColor = System.Drawing.Color.Orange;
            this.ui_newLog.Location = new System.Drawing.Point(0, 0);
            this.ui_newLog.Name = "ui_newLog";
            this.ui_newLog.Size = new System.Drawing.Size(317, 22);
            this.ui_newLog.TabIndex = 0;
            this.ui_newLog.DoubleClick += new System.EventHandler(this.ui_newLog_DoubleClick);
            this.ui_newLog.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ui_newLog_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ui_history);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 248);
            this.panel2.TabIndex = 1;
            // 
            // ui_history
            // 
            this.ui_history.BackColor = System.Drawing.Color.DimGray;
            this.ui_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ui_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_history.Location = new System.Drawing.Point(0, 0);
            this.ui_history.Multiline = true;
            this.ui_history.Name = "ui_history";
            this.ui_history.Size = new System.Drawing.Size(317, 248);
            this.ui_history.TabIndex = 0;
            this.ui_history.DoubleClick += new System.EventHandler(this.ui_newLog_DoubleClick);
            this.ui_history.Enter += new System.EventHandler(this.ui_history_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(317, 267);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ui_newLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ui_history;
    }
}

