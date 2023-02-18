using CalCalculatorEntities;
using System;
using System.CodeDom;
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

        bool sidebarExpand=false;
        bool homeExpand;
        User user;
        public MainFormDeneme(User currentUser)
        {
            InitializeComponent();
            IsMdiContainer = true;
            user = currentUser;
            BackColor = Color.FromArgb(54, 60, 73);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {


            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                this.Width-= 10;
                if (sidebarContainer.Width <= sidebarContainerMinWidth)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                this.Width += 10;
                if (sidebarContainer.Width >= sidebarContainerMaxWidth)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        int sidebarContainerMaxWidth;
        int sidebarContainerMinWidth;
        private void menuButton_Click(object sender, EventArgs e)
        {
            

            //If menu closed
            if (homeContainer.Visible && HelpAboutContainer.Visible && sidebarExpand)
            {
                sidebarContainerMinWidth = sidebarContainer.Width / 3;
                homeContainer.Visible = false;
                HelpAboutContainer.Visible = false;
            }
            else if (!homeContainer.Visible && !HelpAboutContainer.Visible && !sidebarExpand)
            {
                sidebarContainerMaxWidth = sidebarContainer.Width * 3;
                homeContainer.Visible = true;
                HelpAboutContainer.Visible = true;
            }
            sidebarTimer.Start();

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
        Form1 MealForm;
        private void btnCalorieTracker_Click(object sender, EventArgs e)
        {
            if (MealForm == null)
            {
                MealForm = new(user, this,sidebarContainer);
                MealForm.MdiParent = this;
                int height = MealForm.Height + 35;
                int width = MealForm.Width + sidebarContainer.Width +6;
                this.Size = new Size(width, height);
                MealForm.Show();
            }

        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulamadan Çıkış", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) // OK butonuna basılırsa
            {
                // Uygulamayı kapat
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Oturumu Kapat", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) // OK butonuna basılırsa
            {
                //Oturumu kapat
                LoginFormDeneme loginForm = new();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics(user);
            statistics.Show();
            this.Close(); 
        }

        private void MainFormDeneme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Burada örnek olarak Escape tuşuna basıldığında formu küçültüyoruz.
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnMaximizeMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point lastPoint; // Son konum bilgisini tutmak için bir değişken tanımlıyoruz.

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // Son konum bilgisini alıyoruz.
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Sol fare düğmesine basılırsa formun konumu değiştiriliyor.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = Point.Empty; // Son konum bilgisini temizliyoruz.
        }

    }
}
