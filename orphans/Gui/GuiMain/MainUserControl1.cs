using orphans.Gui.GuiHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orphans.Gui.GuiMain
{
    public partial class MainUserControl1 : UserControl
    {
       public static  MainUserControl1 _MainUserControl1;

        public MainUserControl1()
        {
            InitializeComponent();
        }
        public static MainUserControl1 Instance()
        {

            return _MainUserControl1 ?? (new MainUserControl1());
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }

}
