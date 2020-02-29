using NLog;
using NLog.Targets;
using System;
using System.Windows.Forms;

namespace Lemon.NLog.WinForms
{
    [Target("TextBox")]
    public class TextBoxTarget : TargetWithContext
    {
        public TextBox TextBox { get; private set; }

        public TextBoxTarget(TextBox textBox) : base()
        {
            TextBox = textBox;
        }

        protected override void Write(LogEventInfo LogEvent)
        {
            if (!TextBox.IsHandleCreated)
            {
                if (TextBox.InvokeRequired)
                {
                    TextBox.Invoke(new Action(() => { IntPtr pointer = TextBox.Handle; }));
                }
                else
                {
                    IntPtr pointer = TextBox.Handle;
                }
            }

            TextBox.Invoke(new Action(() => TextBox.AppendText(Layout.Render(LogEvent) + Environment.NewLine)));
        }
    }
}
