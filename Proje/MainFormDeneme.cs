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
    public partial class MainFormDeneme : Form
    {
        bool sidebarExpand;
        bool homeExpand;
        public MainFormDeneme()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            if (homeContainer.Visible && HelpAboutContainer.Visible)
            {
                homeContainer.Visible = false;
                HelpAboutContainer.Visible = false;
            }
            else
            {
                homeContainer.Visible = true;
                HelpAboutContainer.Visible = true;
            }
           
        }

        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if (homeExpand)
            {
                homeContainer.Height -= 10;
                if (homeContainer.Height == homeContainer.MinimumSize.Height)
                {
                    homeExpand = false;
                    homeTimer.Stop();
                }
            }
            else
            {
                homeContainer.Height += 10;
                if (homeContainer.Height == homeContainer.MaximumSize.Height)
                {
                    homeExpand = true;
                    homeTimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeTimer.Start();
        }
        User user;
        Form1 MealForm;
        private void btnCalorieTracker_Click(object sender, EventArgs e)
        {
            if (MealForm == null)
            {
                MealForm = new(user);
                MealForm.MdiParent = this;
                int height = this.Size.Height - 5;
                int width = this.Size.Width - sidebarContainer.Width - 5;
                MealForm.Size = new Size(width, height);
                MealForm.Show();
            }
           
        }

    }
}
