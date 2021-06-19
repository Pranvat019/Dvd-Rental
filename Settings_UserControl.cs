﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVD_Rental_Store_Management_System
{
    public partial class Settings_UserControl : UserControl
    {
        private static Settings_UserControl _instance;

        public static Settings_UserControl _Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Settings_UserControl();
                }
                return _instance;
            }
        }

        public Settings_UserControl()
        {
            InitializeComponent();
        }
    }
}
