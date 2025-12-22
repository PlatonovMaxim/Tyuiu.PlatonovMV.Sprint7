using System;
using System.Windows.Forms;

namespace Tyuiu.PlatonovMV.Sprint7.Project.V9
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}