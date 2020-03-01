using Lemon.NLog.WinForms;
using NLog;
using NLog.Config;
using System;
using System.Windows.Forms;

namespace TestApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Home form = new Home();

            LoggingConfiguration config = new LoggingConfiguration();
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, new TextBoxTarget(form.LogTextBox) { Layout = "[${date}] [${level}] ${message}" });
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, new ToolStripStatusLabelTarget(form.LogToolStripStatusLabel) { Layout = "${message}" });
            LogManager.Configuration = config;

            Application.Run(form);
        }
    }
}
