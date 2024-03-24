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

namespace orphans.Gui.Gui_financial_side
{
    public partial class Orphan_salariesUserControl1 : UserControl
    {
        public  static readonly Orphan_salariesUserControl1? _Orphan_salariesUserControl1;

        public Orphan_salariesUserControl1()
        {
            InitializeComponent();
        }

        public static Orphan_salariesUserControl1 Instance()
        {

            return _Orphan_salariesUserControl1 ?? (new Orphan_salariesUserControl1());
        }

        private void buttonSalaryDetails_Click(object sender, EventArgs e)
        {
            Salary_Details salary_Details = new Salary_Details();   
            salary_Details.Show();
        }
    }
}
