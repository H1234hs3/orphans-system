using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orphans.Gui.GuiOrphanOperations
{
    public partial class OrphanDetails : Form
    {



        public OrphanDetails()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var dia =new OpenFileDialog();
            var result=dia.ShowDialog();
            if (result == DialogResult.OK)
            {
               textBox18.Text = dia.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
