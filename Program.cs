using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMultiForm2
{
    internal static class Program
    {
        public static Form_Indulo form_Indulo;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Indulo = new Form_Indulo();
            Application.Run(form_Indulo);
        }
    }
}
