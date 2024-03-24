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

namespace orphans.Gui.Gui_Orphan_Replacement
{
    public partial class Replacement_orphanUserControl1 : UserControl
    {
        public static  readonly Replacement_orphanUserControl1? _Replacement_orphanUserControl1;

        public Replacement_orphanUserControl1()
        {
            InitializeComponent();
        }

        public static Replacement_orphanUserControl1 Instance()
        {

            return _Replacement_orphanUserControl1 ?? (new Replacement_orphanUserControl1());
        }

        private void buttonReplacmentOrphan_Click(object sender, EventArgs e)
        {
            orphan_Replacement orphan_Replacement = new orphan_Replacement();
            orphan_Replacement.Show();
        }

        private void buttonReplacementOrphanDetails_Click(object sender, EventArgs e)
        {
            Replacement_Details replacement_Details = new Replacement_Details();    
            replacement_Details.Show();
        }
    }
}
