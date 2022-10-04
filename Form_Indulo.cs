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
    public partial class Form_Indulo : Form
    {
        public Form_Indulo()
        {
            InitializeComponent();
        }

        private void vivobookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_asus_vivo form_Asus_Vivo=new Form_asus_vivo();
            form_Asus_Vivo.ShowDialog();
        }

        private void zenbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_asus_zen form_Asus_Zen=new Form_asus_zen();
            form_Asus_Zen.ShowDialog();
           
        }

        private void rOGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_asus_rog form_Asus_Rog=new Form_asus_rog();    
            form_Asus_Rog.ShowDialog(); 

        }

        private void lenovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_lenovo_leg form_Lenovo_Leg=new Form_lenovo_leg();  
            form_Lenovo_Leg.ShowDialog();
        }

        private void playstation5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_playstation5 form_Playstation5=new Form_playstation5();
            form_Playstation5.Show();
        }

        private void nitro5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_acer_nitro form_Acer_Nitro=new Form_acer_nitro();  
            form_Acer_Nitro.Show();
        }
    }
}
