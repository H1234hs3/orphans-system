using Microsoft.VisualBasic;
using orphans.Code;
using orphans.Gui.GuiOrphanOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using orphans.Gui;
using orphans.Gui.GuiLoading;

namespace orphans.Gui.GuiHome
{
    public partial class Home : Form
    {
        private readonly pageManager pageManager;
        public Home()
        {
            InitializeComponent();
            pageManager = new pageManager(this);

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {


            if (e.Node != null)
            {
                string selectedOption = e.Node.Name;


                 if (selectedOption == "NodeNewData")
                {

                    pageManager.Loadpage(GuiAdd_new_Orphan.OrphanDataUserControl1.Instance());
                }
                else if (selectedOption == "Dashboard")
                {
                    pageManager.Loadpage(GuiMain.MainUserControl1.Instance());
                }
                else if (selectedOption == "NodeSalary")
                {
                    pageManager.Loadpage(Gui_financial_side.Orphan_salariesUserControl1.Instance());
                }
                else if (selectedOption == "NodeReplacement")
                {
                    pageManager.Loadpage(Gui_Orphan_Replacement.Replacement_orphanUserControl1.Instance());
                }
                else
                {
                    
                }

            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //pageManager.Loadpage(GuiMain.MainUserControl1.Instance());
           
            
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
