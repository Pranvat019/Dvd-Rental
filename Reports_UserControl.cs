using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DVD_Rental_Store_Management_System
{
    public partial class Reports_UserControl : UserControl
    {
        private static Reports_UserControl _instance;

        public static Reports_UserControl _Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Reports_UserControl();
                }
                return _instance;
            }
        }

        public Reports_UserControl()
        {
            InitializeComponent();
        }

        public string Movie, Customer;

        private void Reports_UserControl_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void Movie_label_Click(object sender, EventArgs e)
        {

        }

        private void MoviePurchased_Label_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Search Customer
            con.Open();
            String syntax = "SELECT M_name from Movie where cid ='" + SearchCustomerTextbox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Movie_label.Text = Movie = dr[0].ToString();
            con.Close();

        }


        private void SearchMovieButton_Click(object sender, EventArgs e)
        {
            //to get Purchased by Customer
            con.Open();
            String syntax = "Select c_Id from CUSTOMER where Mname='" + SearchMovieTextbox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            CustomerPurchasedID_label.Text = Customer + dr[0].ToString();
            con.Close();

        }
        
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            //CLEAR ALL BUTTON
            SearchCustomerTextbox.Text = " ";
            SearchMovieTextbox.Text = " ";
            Movie_label.Text = " ";
            CustomerPurchasedID_label.Text = " ";
        }

        private void RentMovieButton_Click(object sender, EventArgs e)
        {
            //See if Movie is already rented to someone
            SearchMovieButton.PerformClick();
            if (Customer != "")
            {
                MessageBox.Show("Movie is already rented to a Customer \n" + Customer);
                return;
            }
            try
            {
                if (Movie == "")
                {
                    //cid should be updated in the Movie slot
                    cmd = new SqlCommand("Transaact_Update__Movie_SP");
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("M_name", SearchMovieTextbox.Text);
                cmd.Parameters.AddWithValue("c_Id", SearchCustomerTextbox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                    <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //now we will also update the cid in the Movie Table
            cmd = new SqlCommand("Transact_Update_Customer_SP");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("M_name", SearchMovieTextbox.Text);
            cmd.Parameters.AddWithValue("c_Id", SearchCustomerTextbox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("                    <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            con.Close();

            /*This completes the entire transaction, so now to update the values, we perform the click event on both the buttons
             so that the user can see the charges made*/
            SearchMovieButton.PerformClick();
            SearchCustomerButton.PerformClick();
            MessageBox.Show("Sucessfully Issued");

        }
    }
}
