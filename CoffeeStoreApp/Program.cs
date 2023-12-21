using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeStoreApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new StatisticIncome());
=======
            //Application.Run(new Login());
            Application.Run(new Manager(new NHANVIEN()));
>>>>>>> 72f48401d5a7e404cc9004e6d88da26cb5c26e44
        }
    }
}
