
namespace DVD_Rental_Store_Management_System
{
    partial class AppBody
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.Log_in_Timer = new System.Windows.Forms.Timer(this.components);
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SlidingPannel_Timer = new System.Windows.Forms.Timer(this.components);
            this.ContentPannel = new System.Windows.Forms.Panel();
            this.SlidingPannel = new System.Windows.Forms.Panel();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.SettingsTabButton = new System.Windows.Forms.Button();
            this.ReportsTabButton = new System.Windows.Forms.Button();
            this.StaffTabButton = new System.Windows.Forms.Button();
            this.CustomersTabButton = new System.Windows.Forms.Button();
            this.MoviesTabButton = new System.Windows.Forms.Button();
            this.SlidingPannel_ToggleButton = new System.Windows.Forms.Button();
            this.TitleBarPanel.SuspendLayout();
            this.SlidingPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_Timer
            // 
            this.Log_in_Timer.Interval = 50;
            this.Log_in_Timer.Tick += new System.EventHandler(this.Log_in_Timer_Tick);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.TitleBarPanel.Controls.Add(this.LogOffButton);
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.closeButton);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(1157, 46);
            this.TitleBarPanel.TabIndex = 0;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // LogOffButton
            // 
            this.LogOffButton.BackgroundImage = global::DVD_Rental_Store_Management_System.Properties.Resources.logout_button;
            this.LogOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.LogOffButton.Location = new System.Drawing.Point(1032, 3);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(41, 37);
            this.LogOffButton.TabIndex = 2;
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.MinimizeButton.Location = new System.Drawing.Point(1079, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(33, 37);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::DVD_Rental_Store_Management_System.Properties.Resources.close1_button;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.closeButton.Location = new System.Drawing.Point(1118, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 37);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SlidingPannel_Timer
            // 
            this.SlidingPannel_Timer.Interval = 50;
            this.SlidingPannel_Timer.Tick += new System.EventHandler(this.SlidingPannel_Timer_Tick);
            // 
            // ContentPannel
            // 
            this.ContentPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPannel.Location = new System.Drawing.Point(304, 46);
            this.ContentPannel.Name = "ContentPannel";
            this.ContentPannel.Size = new System.Drawing.Size(853, 856);
            this.ContentPannel.TabIndex = 4;
            // 
            // SlidingPannel
            // 
            this.SlidingPannel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SlidingPannel.BackgroundImage = global::DVD_Rental_Store_Management_System.Properties.Resources.sliding_panel_2;
            this.SlidingPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPannel.Controls.Add(this.AboutTabButton);
            this.SlidingPannel.Controls.Add(this.SettingsTabButton);
            this.SlidingPannel.Controls.Add(this.ReportsTabButton);
            this.SlidingPannel.Controls.Add(this.StaffTabButton);
            this.SlidingPannel.Controls.Add(this.CustomersTabButton);
            this.SlidingPannel.Controls.Add(this.MoviesTabButton);
            this.SlidingPannel.Controls.Add(this.SlidingPannel_ToggleButton);
            this.SlidingPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPannel.Location = new System.Drawing.Point(0, 46);
            this.SlidingPannel.Name = "SlidingPannel";
            this.SlidingPannel.Size = new System.Drawing.Size(302, 856);
            this.SlidingPannel.TabIndex = 3;
            this.SlidingPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTabButton.Image = global::DVD_Rental_Store_Management_System.Properties.Resources.iconfinder_7099610_about_faq_service_info_help_icon_64px;
            this.AboutTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutTabButton.Location = new System.Drawing.Point(0, 398);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(300, 60);
            this.AboutTabButton.TabIndex = 6;
            this.AboutTabButton.Text = "ABOUT";
            this.AboutTabButton.UseVisualStyleBackColor = false;
            this.AboutTabButton.Click += new System.EventHandler(this.AboutTabButton_Click);
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTabButton.Image = global::DVD_Rental_Store_Management_System.Properties.Resources.iconfinder_326693_applications_settings_icon_48px;
            this.SettingsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsTabButton.Location = new System.Drawing.Point(-2, 330);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(300, 60);
            this.SettingsTabButton.TabIndex = 5;
            this.SettingsTabButton.Text = "SETTINGS";
            this.SettingsTabButton.UseVisualStyleBackColor = false;
            this.SettingsTabButton.Click += new System.EventHandler(this.SettingsTabButton_Click);
            // 
            // ReportsTabButton
            // 
            this.ReportsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.ReportsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsTabButton.Image = global::DVD_Rental_Store_Management_System.Properties.Resources.iconfinder_43328_my_reports_icon_32px;
            this.ReportsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsTabButton.Location = new System.Drawing.Point(-2, 264);
            this.ReportsTabButton.Name = "ReportsTabButton";
            this.ReportsTabButton.Size = new System.Drawing.Size(300, 60);
            this.ReportsTabButton.TabIndex = 4;
            this.ReportsTabButton.Text = "REPORTS";
            this.ReportsTabButton.UseVisualStyleBackColor = false;
            this.ReportsTabButton.Click += new System.EventHandler(this.ReportsTabButton_Click);
            // 
            // StaffTabButton
            // 
            this.StaffTabButton.BackColor = System.Drawing.Color.Transparent;
            this.StaffTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffTabButton.Image = global::DVD_Rental_Store_Management_System.Properties.Resources.iconfinder_131484_profile_manager_man_male_business_icon_32px;
            this.StaffTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffTabButton.Location = new System.Drawing.Point(-2, 198);
            this.StaffTabButton.Name = "StaffTabButton";
            this.StaffTabButton.Size = new System.Drawing.Size(300, 60);
            this.StaffTabButton.TabIndex = 3;
            this.StaffTabButton.Text = "STAFF";
            this.StaffTabButton.UseVisualStyleBackColor = false;
            this.StaffTabButton.Click += new System.EventHandler(this.StaffTabButton_Click);
            // 
            // CustomersTabButton
            // 
            this.CustomersTabButton.BackColor = System.Drawing.Color.Transparent;
            this.CustomersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersTabButton.Image = global::DVD_Rental_Store_Management_System.Properties.Resources.iconfinder_3209291_contacts_customers_family_group_team_icon_24px;
            this.CustomersTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersTabButton.Location = new System.Drawing.Point(-2, 132);
            this.CustomersTabButton.Name = "CustomersTabButton";
            this.CustomersTabButton.Size = new System.Drawing.Size(300, 60);
            this.CustomersTabButton.TabIndex = 2;
            this.CustomersTabButton.Text = "CUSTOMERS";
            this.CustomersTabButton.UseVisualStyleBackColor = false;
            this.CustomersTabButton.Click += new System.EventHandler(this.CustomersTabButton_Click);
            // 
            // MoviesTabButton
            // 
            this.MoviesTabButton.BackColor = System.Drawing.Color.Transparent;
            this.MoviesTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoviesTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviesTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesTabButton.Image = global::DVD_Rental_Store_Management_System.Properties.Resources.iconfinder_290127_movies_music_videos_icon_32px;
            this.MoviesTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoviesTabButton.Location = new System.Drawing.Point(-2, 66);
            this.MoviesTabButton.Name = "MoviesTabButton";
            this.MoviesTabButton.Size = new System.Drawing.Size(302, 60);
            this.MoviesTabButton.TabIndex = 1;
            this.MoviesTabButton.Text = "MOVIES";
            this.MoviesTabButton.UseVisualStyleBackColor = false;
            this.MoviesTabButton.Click += new System.EventHandler(this.MoviesTabButton_Click);
            // 
            // SlidingPannel_ToggleButton
            // 
            this.SlidingPannel_ToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SlidingPannel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPannel_ToggleButton.Image = global::DVD_Rental_Store_Management_System.Properties.Resources.Rightarrow;
            this.SlidingPannel_ToggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidingPannel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPannel_ToggleButton.Name = "SlidingPannel_ToggleButton";
            this.SlidingPannel_ToggleButton.Size = new System.Drawing.Size(300, 60);
            this.SlidingPannel_ToggleButton.TabIndex = 0;
            this.SlidingPannel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPannel_ToggleButton.Click += new System.EventHandler(this.SlidinPannel_ToggleButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 902);
            this.Controls.Add(this.ContentPannel);
            this.Controls.Add(this.SlidingPannel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.SlidingPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_Timer;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel SlidingPannel;
        private System.Windows.Forms.Button SlidingPannel_ToggleButton;
        private System.Windows.Forms.Timer SlidingPannel_Timer;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button SettingsTabButton;
        private System.Windows.Forms.Button ReportsTabButton;
        private System.Windows.Forms.Button StaffTabButton;
        private System.Windows.Forms.Button CustomersTabButton;
        private System.Windows.Forms.Button MoviesTabButton;
        private System.Windows.Forms.Panel ContentPannel;
    }
}