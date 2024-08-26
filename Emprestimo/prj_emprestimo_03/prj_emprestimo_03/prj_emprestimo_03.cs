using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace prj_emprestimo_03
{
    static class prj_emprestimo_03
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmemprestimo_03());
        }
    }
}
