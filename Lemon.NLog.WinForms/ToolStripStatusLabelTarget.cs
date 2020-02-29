using NLog;
using NLog.Targets;
using System;
using System.Windows.Forms;

namespace Lemon.NLog.WinForms
{
    /// <summary>
    /// Logs text into a Tool Strip Status Label control in an existing form.
    /// </summary>
    [Target("ToolStripStatusLabel")]
    public class ToolStripStatusLabelTarget : TargetWithContext
    {
        /// <summary>
        /// The ToolStripStatusLabel control that will be used for this
        /// </summary>
        public ToolStripStatusLabel TargetStatusLabel { get; private set; }

        public ToolStripStatusLabelTarget(ToolStripStatusLabel statusLabel) : base()
        {
            TargetStatusLabel = statusLabel;
        }

        protected override void Write(LogEventInfo LogEvent)
        {
            // Start by formatting the text that we need
            string text = Layout.Render(LogEvent);

            // If we need to invoke
            if (TargetStatusLabel.Owner.InvokeRequired)
            {
                // If a handle has not been created for this TextBox
                if (!TargetStatusLabel.Owner.IsHandleCreated)
                {
                    // Get the pointer/handle of the TextBox (is silently created if not)
                    TargetStatusLabel.Owner.Invoke(new Action(() => { _ = TargetStatusLabel.Owner.Handle; }));
                }

                // Then, replace the text
                TargetStatusLabel.Owner.Invoke(new Action(() => TargetStatusLabel.Text = text));
            }
            // Otherwise, do the same things without invoking
            else
            {
                if (!TargetStatusLabel.Owner.IsHandleCreated)
                {
                    _ = TargetStatusLabel.Owner.Handle;
                }

                TargetStatusLabel.Text = text;
            }
        }
    }
}
