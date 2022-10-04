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
    public partial class Form_lenovo_leg : Form
    {
        public Form_lenovo_leg()
        {
            InitializeComponent();
        }

        private void Form_lenovo_leg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Tényleg beszeretné zárni?", "Kérdés",MessageBoxButtons.YesNo) == DialogResult.Yes)
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
