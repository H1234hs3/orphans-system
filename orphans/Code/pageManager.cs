using orphans.Gui.GuiHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orphans.Code
{
    public class pageManager
    {
        private readonly Home home;

        public pageManager(Home home) {
            this.home = home;
        }
        public void Loadpage(UserControl pageUserControl) {
        
        var oldPage=home.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();

            if (oldPage != null) { 
                home.panelContainer.Controls.Remove(oldPage);
                oldPage.Dispose();
           
            }
            pageUserControl.Dock = DockStyle.Fill;
            home.panelContainer.Controls.Add(pageUserControl);

        }
    }
}
