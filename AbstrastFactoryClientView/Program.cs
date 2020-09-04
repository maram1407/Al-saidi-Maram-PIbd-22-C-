using AbstrastFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstrastFactoryClientView
{
   static class Program
    {
        public static ClientViewModel Client { get; set; }
        [STAThread]
        static void Main()
        {
            APIClient.Connect();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new FormEnter();
            form.ShowDialog();
            if (Client != null)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
