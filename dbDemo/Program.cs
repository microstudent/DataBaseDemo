using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new PosLoginForm());
            //Application.Run(new PosForm());
            //Application.Run(new InputForm());
            //Application.Run(new SupplierForm());
            //Application.Run(new CommodityForm());

        }
    }
}
