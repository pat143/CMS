using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
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
            Application.Run(new promote_student());
            //Application.Run(new student_add());
            //Application.Run(new student_search());
            //Application.Run(new fees());
           //Application.Run(new fee_structure());
        }
    }
}
