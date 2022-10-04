using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMultiForm2
{
    public partial class Form_acer_nitro : Form
    {
        public Form_acer_nitro()
        {
            InitializeComponent();
        }

        private void Form_acer_nitro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Szeretnéd bezárni?", "Kérdés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.form_Indulo.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
