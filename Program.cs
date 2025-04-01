using System;
using System.Windows.Forms;

namespace SeninBorcun
{
    static class Program
    { 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainMenu mainMenu = new MainMenu(); // Ana menüyü aç
            mainMenu.Icon = new System.Drawing.Icon("data/app.ico"); // İkonu ekle
            Application.Run(mainMenu);
        }
    }
}
