using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonInvasiveKeyboardHookLibrary;

namespace Evidence
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Registers F5 hotkey to be used globally for image capture even if application is out of focus
            var keyboardHookManager = new KeyboardHookManager();
            keyboardHookManager.Start();

            // F5 key pressed
            keyboardHookManager.RegisterHotkey(0x74, () =>
            {
                Form1 f1 = new Form1();
                f1.captureImage();
                f1.Dispose();
                Debug.WriteLine("F5 detected");
            });

        }
    }
}
