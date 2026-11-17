using System;
using System.Windows.Forms;

namespace ComputerSales
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Environment.CurrentDirectory = Application.StartupPath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
