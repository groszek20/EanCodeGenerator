using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorKodów
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

            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
                Application.Run(new Form1(f.User, f.Pass, f.Server, f.Db ) );
        }
    }
}
