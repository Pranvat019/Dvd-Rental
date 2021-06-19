using System;
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
    public partial class Staff_UserControl : UserControl
    {
        private static Staff_UserControl _instance;

        public static Staff_UserControl _Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Staff_UserControl();
                }
                return _instance;
            }
        }

        public Staff_UserControl()
        {
            InitializeComponent();
        }
    }
}
