using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LazyButton
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Организуем запрет на запуск второго экземпляра приложения.
            bool oneonly;
            Mutex m = new Mutex(true, "LazyButton", out oneonly);
            if (oneonly)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                
            }
            else
            {
                MessageBox.Show("Это приложение уже запущено.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
