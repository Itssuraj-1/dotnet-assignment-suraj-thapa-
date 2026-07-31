// Program.cs
// Entry point of the Windows Forms application.
using System;
using System.Windows.Forms;

namespace Q12_FormCalculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}