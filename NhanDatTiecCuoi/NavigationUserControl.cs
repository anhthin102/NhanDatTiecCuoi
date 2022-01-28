using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanDatTiecCuoi
{
    public class NavigationUserControl
    {
        Panel panel;
        List<UserControl> userControls = new List<UserControl>();

        public NavigationUserControl(Panel panel, List<UserControl> userControls)
        {
            this.panel = panel;
            this.userControls = userControls;
            AddUserControls();
        }
        private void AddUserControls()
        {
            for(int i=0; i<userControls.Count(); i++)
            {
                userControls[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControls[i]);
            }
        }
        public void Display(int index)
        {
            if (index < userControls.Count())
            {
                userControls[index].BringToFront();
            }
        }
    }
}
