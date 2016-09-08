using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ranta.MutexDemo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (Mutex mutext = new Mutex(true, "HAHAHA"))
            {
                if (mutext.WaitOne(0, false))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Form form = new Form();
                    form.Text = "Hello Mutext";
                    Application.Run(form);
                }
                else
                {
                    MessageBox.Show("There is already a running instance of the application.");
                }
            }
        }
    }
}
