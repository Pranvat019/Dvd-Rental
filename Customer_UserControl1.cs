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
    public partial class Customer_UserControl1 : UserControl
    {
        private static Customer_UserControl1 _instance;

        public static Customer_UserControl1 _Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Customer_UserControl1();
                }
                return _instance;
            }
        }

        public Customer_UserControl1()
        {
            InitializeComponent();
        }

        private void Customer_UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
