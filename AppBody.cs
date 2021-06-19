using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DVD_Rental_Store_Management_System
{
    public partial class AppBody : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                           int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public AppBody()
        {
            InitializeComponent();

            //initialisations for Sliding Panel
            isSlidingPannelExpanded = true;
            expandSlidingPannelGUI();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_Timer.Start();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Log_in_Timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_in_Timer.Stop();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        //Sliding Panel Code Starts From Here
        bool isSlidingPannelExpanded;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 80;


        private void SlidinPannel_ToggleButton_Click(object sender, EventArgs e)
        {
            if(isSlidingPannelExpanded)
            {
                //retractSlidingPannelGUI();
            }
            SlidingPannel_Timer.Start();
        }

        private void SlidingPannel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                // retract panel
                SlidingPannel.Width -= 30;
                if(SlidingPannel.Width <= MinSliderWidth)
                {
                    // Stop retract
                    isSlidingPannelExpanded = false;
                    SlidingPannel_Timer.Stop();
                    retractSlidingPannelGUI();
                    this.Refresh();
                }
            }
            else
            {
                //expand the panel
                SlidingPannel.Width += 30;
                if (SlidingPannel.Width >= MaxSliderWidth)
                {
                    // Stop expanding
                    isSlidingPannelExpanded = true;
                    SlidingPannel_Timer.Stop();
                    expandSlidingPannelGUI();
                    this.Refresh();
                }
            }
            
        }
        private void expandSlidingPannelGUI()
        {
            //GUI adjustments for expanding
            MoviesTabButton.Text = "MOVIES";
            CustomersTabButton.Text = "CUSTOMERS";
            StaffTabButton.Text = "STAFF";
            ReportsTabButton.Text = "REPORTS";
            SettingsTabButton.Text = "SETTINGS";
            AboutTabButton.Text = "ABOUT";
            SlidingPannel_ToggleButton.Image = Properties.Resources.Leftarrow;
            MoviesTabButton.Image = null;
            CustomersTabButton.Image = null;
            StaffTabButton.Image = null;
            ReportsTabButton.Image = null;
            SettingsTabButton.Image = null;
            AboutTabButton.Image = null;
        }
        private void retractSlidingPannelGUI()
        {
            //GUI adjustments for expanding
            MoviesTabButton.Text = "";
            CustomersTabButton.Text = "";
            StaffTabButton.Text = "";
            ReportsTabButton.Text = "";
            SettingsTabButton.Text = "";
            AboutTabButton.Text = "";

            SlidingPannel_ToggleButton.Image = Properties.Resources.Rightarrow;

            MoviesTabButton.Image = Properties.Resources.iconfinder_290127_movies_music_videos_icon_32px;
            CustomersTabButton.Image = Properties.Resources.iconfinder_3209291_contacts_customers_family_group_team_icon_24px;
            StaffTabButton.Image = Properties.Resources.iconfinder_131484_profile_manager_man_male_business_icon_32px;
            ReportsTabButton.Image = Properties.Resources.iconfinder_43328_my_reports_icon_32px;
            SettingsTabButton.Image = Properties.Resources.iconfinder_326693_applications_settings_icon_48px;
            AboutTabButton.Image = Properties.Resources.iconfinder_7099610_about_faq_service_info_help_icon_64px;
        }

        private void MoviesTabButton_Click(object sender, EventArgs e)
        {
            if(! ContentPannel.Controls.Contains(Movies_UserControl._Instance))
            {
                ContentPannel.Controls.Add(Movies_UserControl._Instance);
                Movies_UserControl._Instance.Dock = DockStyle.Fill;
                Movies_UserControl._Instance.BringToFront();
            }
            else
            {
                Movies_UserControl._Instance.BringToFront();
            }
        }

        private void CustomersTabButton_Click(object sender, EventArgs e)
        {
            if (! ContentPannel.Controls.Contains(Customer_UserControl1._Instance))
            {
                ContentPannel.Controls.Add(Customer_UserControl1._Instance);
                Customer_UserControl1._Instance.Dock = DockStyle.Fill;
                Customer_UserControl1._Instance.BringToFront();
            }
            else
            {
                Customer_UserControl1._Instance.BringToFront();
            }
        }

        private void StaffTabButton_Click(object sender, EventArgs e)
        {
            if (! ContentPannel.Controls.Contains(Staff_UserControl._Instance))
            {
                ContentPannel.Controls.Add(Staff_UserControl._Instance);
                Staff_UserControl._Instance.Dock = DockStyle.Fill;
                Staff_UserControl._Instance.BringToFront();
            }
            else
            {
                Staff_UserControl._Instance.BringToFront();
            }
        }

        private void ReportsTabButton_Click(object sender, EventArgs e)
        {
            if (! ContentPannel.Controls.Contains(Reports_UserControl._Instance))
            {
                ContentPannel.Controls.Add(Reports_UserControl._Instance);
                Reports_UserControl._Instance.Dock = DockStyle.Fill;
                Reports_UserControl._Instance.BringToFront();
            }
            else
            {
                Reports_UserControl._Instance.BringToFront();
            }
        }

        private void SettingsTabButton_Click(object sender, EventArgs e)
        {
            if (! ContentPannel.Controls.Contains(Settings_UserControl._Instance))
            {
                ContentPannel.Controls.Add(Settings_UserControl._Instance);
                Settings_UserControl._Instance.Dock = DockStyle.Fill;
                Settings_UserControl._Instance.BringToFront();
            }
            else
            {
                Settings_UserControl._Instance.BringToFront();
            }
        }

        private void AboutTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(About_UserControl._Instance))
            {
                ContentPannel.Controls.Add(About_UserControl._Instance);
                About_UserControl._Instance.Dock = DockStyle.Fill;
                Settings_UserControl._Instance.BringToFront();
            }
            else
            {
                About_UserControl._Instance.BringToFront();
            }
        }
    }
}
