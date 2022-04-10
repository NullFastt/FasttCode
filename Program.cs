using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FasttCode
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(File.Exists(Application.LocalUserAppDataPath + @"////Pass.fasttcodding"))
            {
                Application.Run(new LoginPass());
            } else
            {
                Application.Run(new RegisPass());
            } 
        }
    }
}
