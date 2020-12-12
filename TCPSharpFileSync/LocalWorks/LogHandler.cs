﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPSharpFileSync
{
    /// <summary>
    /// Class that represents all the log working, including progress that's shown to user.
    /// </summary>
    public static class LogHandler
    {
        /// <summary>
        /// Delegate that invokes writing given text to a RichTextBox with specific color.
        /// </summary>
        public static Action<string, Color> RichTextBoxWriteDelegate;
        /// <summary>
        /// Delegate that made to set the ProgressBar max value.
        /// </summary>
        public static Action<int> SetProgressBarMax;
        /// <summary>
        /// Delegate that made to increment ProgressBar value by 1.
        /// </summary>
        public static Action IncrementProgressBar;
        /// <summary>
        /// Delegate that made to set ProgressBar value to 0.
        /// </summary>
        public static Action ResetProgressBar;

        /// <summary>
        /// Function that invokes writing to the RichTextBox delegate with standart text color.
        /// </summary>
        /// <param name="s">Text that has to be written.</param>
        public static void WriteLog(string s)
        {
            RichTextBoxWriteDelegate.Invoke(s, SystemColors.WindowText);
            Application.DoEvents();
        }

        /// <summary>
        /// Function that invokes writing to the RichTextBox delegate with specific text color.
        /// </summary>
        /// <param name="s">Text that has to be written.</param>
        /// <param name="c">Color of the given text.</param>
        public static void WriteLog(string s, Color c)
        {
            RichTextBoxWriteDelegate.Invoke(s, c);
            Application.DoEvents();
        }

        /// <summary>
        /// Function that invokes delegate that sets ProgressBat max value.
        /// </summary>
        /// <param name="max">Value that has to be set.</param>
        public static void SetProgressBarMaxValue(int max) 
        {
            SetProgressBarMax.Invoke(max);
        }

        /// <summary>
        /// Function that invokes delegate that increments ProgressBar value by 1.
        /// </summary>
        public static void IncrementProgressBarValue() 
        {
            IncrementProgressBar.Invoke();
        }

        /// <summary>
        /// Function that invokes delegate that sets ProgressBar value to 0.
        /// </summary>
        public static void ResetProgressBarValue()
        {
            ResetProgressBar.Invoke();
        }
    }
}