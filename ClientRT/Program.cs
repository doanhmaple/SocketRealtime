using ClientRT.GUI;
using System;
using System.Windows.Forms;
using DevExpress.UserSkins;

namespace ClientRT
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            Application.Run(new Login());
        }
    }
}
