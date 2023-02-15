using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class AdminPanelDeneme : Form
    {
        bool sidebarExpand;
        public AdminPanelDeneme()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {


            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            //If menu closed
            if (homeContainer.Visible && sidebarContainer.Width > 230)
            {
                homeContainer.Visible = false;
            }
            else if (!homeContainer.Visible  && sidebarContainer.Width < 85)
            {
                homeContainer.Visible = true;
            }

        }
        
        

    }
}

