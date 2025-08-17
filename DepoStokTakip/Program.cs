using System;
using System.Windows.Forms;

namespace DepoStokTakip
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Login formunu aç
            Application.Run(new FormLogin());
        }
    }
}
