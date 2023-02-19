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
    public partial class AdminPanel : Form
    {
        
        bool sidebarExpand;
        User user;
        CreateFood createFoodForm;
        CreateCategory createCategoryForm;
        public AdminPanel(User currentUser)
        {
            InitializeComponent();
            IsMdiContainer = true;
            user = currentUser;
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {


            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                this.Width -= 10;
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
            if (homeContainer.Visible && sidebarExpand)
            {
                sidebarContainerMinWidth = sidebarContainer.Width / 3;
                homeContainer.Visible = false;
            }
            else if (!homeContainer.Visible && !sidebarExpand)
            {
                sidebarContainerMaxWidth = sidebarContainer.Width * 3;
                homeContainer.Visible = true;
            }
            sidebarTimer.Start();

        }

        private void btnContinueAsAnUser_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new(user);
            mainForm.Show();
            this.Close();
        }
        private void btnCreateFood_Click(object sender, EventArgs e)
        {

            createFoodForm = new();
            createFoodForm.MdiParent = this;
            int height = createFoodForm.Height + 35;
            int width = createFoodForm.Width + sidebarContainer.Width + 6;
            this.Size = new Size(width, height);
           
            if(this.ActiveMdiChild != null ) 
            {
                this.ActiveMdiChild.Close();
                
            }
            createFoodForm.Show();


        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {

            createCategoryForm = new();
            createCategoryForm.MdiParent = this;
            int height = createCategoryForm.Height + 35;
            int width = createCategoryForm.Width + sidebarContainer.Width + 6;
            this.Size = new Size(width, height);
           
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            createCategoryForm.Show();


        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulamadan Çıkış", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) // OK butonuna basıldı
            {
                // Uygulamayı kapat
                Application.Exit();
            }
        }

        private void btnMaximizeMinimize_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
            //else if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.WindowState = FormWindowState.Normal;
            //}
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point lastPoint; // Son konum bilgisini tutmak için bir değişken tanımlıyoruz.
        private void AdminPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // Son konum bilgisini alıyoruz.
        }

        private void AdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Sol fare düğmesine basılırsa formun konumu değiştiriliyor.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AdminPanel_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = Point.Empty; // Son konum bilgisini temizliyoruz.
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            Image image;
            using (MemoryStream ms = new MemoryStream(user.Photo))
            {
                image = Image.FromStream(ms);
            }
            pictureBox1.Image = image;
        }
    }
}

