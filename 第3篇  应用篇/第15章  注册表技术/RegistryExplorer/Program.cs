using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RegistryExplorer
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
            Application.Run(new FormExplorer());
//FormExplorer formExplorer = new FormExplorer();
//formExplorer.Load += new EventHandler(formExplorer_Load);
        }

//static void formExplorer_Load(object sender, EventArgs e)
//{
//    throw new NotImplementedException();
//}
    }
}
