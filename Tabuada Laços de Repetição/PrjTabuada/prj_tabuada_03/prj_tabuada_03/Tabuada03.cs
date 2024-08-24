using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace prj_tabuada_03
{
    static class Tabuada03
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tabuada_03());
        }
    }
}
