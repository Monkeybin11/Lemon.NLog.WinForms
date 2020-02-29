using NLog;
using NLog.Targets;
using System;
using System.Windows.Forms;

namespace Lemon.NLog.WinForms
{
    [Target("TextBox")]
    public class TextBoxTarget : TargetWithContext
    {
        public TextBox TargetTextBox { get; private set; }

        public TextBoxTarget(TextBox textBox) : base()
        {
            TargetTextBox = textBox;
        }

        protected override void Write(LogEventInfo LogEvent)
        {
            if (!TargetTextBox.IsHandleCreated)
            {
                if (TargetTextBox.InvokeRequired)
                {
                    TargetTextBox.Invoke(new Action(() => { IntPtr pointer = TargetTextBox.Handle; }));
                }
                else
                {
                    IntPtr pointer = TargetTextBox.Handle;
                }
            }

            TargetTextBox.Invoke(new Action(() => TargetTextBox.AppendText(Layout.Render(LogEvent) + Environment.NewLine)));
        }
    }
}
