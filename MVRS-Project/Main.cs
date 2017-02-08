using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace MVRS_Project
{
    public partial class Main : Form
    {
        SignUp signup;
        AddVehicle addVehicle;
        string conString;
        public Main()
        {
            InitializeComponent();
            signup = new SignUp();
            addVehicle = new AddVehicle();
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "ddd dd MMM yyyy";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "ddd dd MMM yyyy";
            cmbLocation.SelectedIndex = 0;
            cmbInsuranceType.SelectedIndex = 0;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            signup.ShowDialog();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (MySqlConnection mysql = new MySqlConnection(conString))
            {
                using (MySqlCommand myCommand = new MySqlCommand("LoginUser", mysql))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@usrname", txtUsrname.Text);
                    myCommand.Parameters.AddWithValue("@passwd", txtPassword.Text);
                    
                    using (MySqlDataAdapter da = new MySqlDataAdapter(myCommand))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
                        if (loginSuccessful)
                        {
                            string userType = ds.Tables[0].Rows[0]["type_of_user"].ToString();
                            Program.user_name = txtUsrname.Text;
                            if (userType == "admin")
                            {
                                tblessCtrl.SelectTab("tabPage2");
                            }
                            else if (userType == "reg_user")
                            {
                                tblessCtrl.SelectTab("tabPage3");
                            }

                            tlStripLbl.Text = "Successful login";
                        }
                        else
                        {
                            tlStripLbl.Text = "Invalid login.";
                            txtUsrname.Clear();
                            txtPassword.Clear();
                        }
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            tblessCtrl.SelectTab("tabPage1");
            txtUsrname.Clear();
            txtPassword.Clear();
            tlStripLbl.Text = "Logout successful";
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            string cmd = "SELECT * FROM vehicledetails";
            MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(cmd, mysql);
            DataSet ds = new DataSet();
            mysqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            if (dataGridView1.Rows.Count > 0 && dataGridView1.ColumnCount > 0)
                tlStripLbl.Text = "All vehicles loaded.";
            else
                tlStripLbl.Text = "No content available in Vehicle Database.";
        }

        private void btnLogoutRegUser_Click(object sender, EventArgs e)
        {
            tblessCtrl.SelectTab("tabPage1");
            txtUsrname.Clear();
            txtPassword.Clear();
            tlStripLbl.Text = "Logout successful";
        }

        private void btnViewAvailblVehicls_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (MySqlConnection mysql = new MySqlConnection(conString))
            {
                using (MySqlCommand myCommand = new MySqlCommand("ViewAvailableVehicles", mysql))
                {
                    using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                    {
                        myCommand.CommandType = CommandType.StoredProcedure;
                        MySqlParameter param;
                        param = new MySqlParameter("@startdate", MySqlDbType.DateTime);
                        param.Value = dtpStart.Value.Date;
                        myCommand.Parameters.Add(param);
                        param = new MySqlParameter("@enddate", MySqlDbType.DateTime);
                        param.Value = dtpEnd.Value.Date;
                        myCommand.Parameters.Add(param);
                        myCommand.Parameters.AddWithValue("@locationid", "NOLOCATION");
                        DataSet ds = new DataSet();
                        mysqlDataAdapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0].DefaultView;
                        if (dataGridView2.Rows.Count <= 0 && dataGridView2.ColumnCount <= 0)
                            tlStripLbl.Text = "No Available vehicles for selected date.";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addVehicle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                using (MySqlConnection mysql = new MySqlConnection(conString))
                {
                    mysql.Open();

                    using (MySqlCommand myCommand = new MySqlCommand("DeleteVehicle", mysql))
                    {
                        using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                        {
                            myCommand.CommandType = CommandType.StoredProcedure;
                            myCommand.Parameters.AddWithValue("@vehicleid", Convert.ToInt32(item.Cells["vehicle_id"].Value));

                            if (1 == myCommand.ExecuteNonQuery()) tlStripLbl.Text = "Selected entry deleted successfully.";
                            else tlStripLbl.Text = "Error in deleting the selected entries.";

                            dataGridView1.Rows.RemoveAt(item.Index);
                        }
                    }

                    mysql.Close();
                }
            }
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                using (MySqlConnection mysql = new MySqlConnection(conString))
                {
                    mysql.Open();
                    
                    using (MySqlCommand myCommand = new MySqlCommand("UpdateVehicle", mysql))
                    {
                        using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                        {
                            myCommand.CommandType = CommandType.StoredProcedure;
                            myCommand.Parameters.AddWithValue("@mdl", dataGridView1.SelectedRows[0].Cells["model"].Value.ToString());
                            myCommand.Parameters.AddWithValue("@yr", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["year"].Value.ToString()));
                            myCommand.Parameters.AddWithValue("@clr", dataGridView1.SelectedRows[0].Cells["color"].Value.ToString());
                            myCommand.Parameters.AddWithValue("@seatcapacity", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["seat_capacity"].Value.ToString()));
                            myCommand.Parameters.AddWithValue("@isavailable", dataGridView1.SelectedRows[0].Cells["is_available"].Value.ToString());
                            myCommand.Parameters.AddWithValue("@costperday", dataGridView1.SelectedRows[0].Cells["cost_per_day"].Value.ToString());
                            myCommand.Parameters.AddWithValue("@costpermile", dataGridView1.SelectedRows[0].Cells["cost_per_mile"].Value.ToString());
                            myCommand.Parameters.AddWithValue("@ctgry", dataGridView1.SelectedRows[0].Cells["category"].Value.ToString());
                            myCommand.Parameters.AddWithValue("@cndtnd", dataGridView1.SelectedRows[0].Cells["conditioned"].Value.ToString());
                            myCommand.Parameters.AddWithValue("@vehclid", dataGridView1.SelectedRows[0].Cells["vehicle_id"].Value.ToString());
                            myCommand.Parameters.AddWithValue("@locationid", dataGridView1.SelectedRows[0].Cells["location_id"].Value.ToString());
                            if (1 == myCommand.ExecuteNonQuery()) tlStripLbl.Text = "Selected entry updated successfully.";
                            else tlStripLbl.Text = "Error in updating the selected entry.";
                        }
                    }

                    mysql.Close();
                }
            }
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            string cmd = "SELECT * FROM user";
            MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(cmd, mysql);
            DataSet ds = new DataSet();
            mysqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            if (dataGridView1.Rows.Count > 0 && dataGridView1.ColumnCount > 0)
                tlStripLbl.Text = "All users loaded.";
            else
                tlStripLbl.Text = "No content available in User Database.";
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile u = new UpdateProfile();
            u.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCard c = new AddCard();
            c.ShowDialog();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            mysql.Open();

            string cmd1 = "SELECT user_id FROM usercredentials WHERE user_name = '" + Program.user_name + "';";
            MySqlDataAdapter mysqlDataAdapter1 = new MySqlDataAdapter(cmd1, mysql);
            DataSet ds1 = new DataSet();
            mysqlDataAdapter1.Fill(ds1);

            string cmd = "SELECT * FROM carddetails WHERE user_id = '" + ds1.Tables[0].Rows[0]["user_id"].ToString() + "';";
            MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(cmd, mysql);
            DataSet ds = new DataSet();
            mysqlDataAdapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;

            mysql.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 1)
            {
                MessageBox.Show("Select only one row for booking");
            }
            else
            {
                conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                using (MySqlConnection mysql = new MySqlConnection(conString))
                {
                    mysql.Open();
                    using (MySqlCommand myCommand = new MySqlCommand("BookVehicle", mysql))
                    {
                        try
                        {
                            string cmd1 = "SELECT user_id FROM usercredentials WHERE user_name = '" + Program.user_name + "';";
                            MySqlDataAdapter mysqlDataAdapter1 = new MySqlDataAdapter(cmd1, mysql);
                            DataSet ds1 = new DataSet();
                            mysqlDataAdapter1.Fill(ds1);
                            
                            using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                            {
                                myCommand.CommandType = CommandType.StoredProcedure;
                                
                                myCommand.Parameters.AddWithValue("@startdate", dtpStart.Value.Date.ToString("yyyy-MM-dd"));
                                myCommand.Parameters.AddWithValue("@enddate", dtpEnd.Value.Date.ToString("yyyy-MM-dd"));
                                myCommand.Parameters.AddWithValue("@rentalamount", Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["cost_per_day"].FormattedValue.ToString()));
                                myCommand.Parameters.AddWithValue("@depositamount", 500);
                                myCommand.Parameters.AddWithValue("@totalamountpaid", 0);
                                myCommand.Parameters.AddWithValue("@insurancetype", cmbInsuranceType.SelectedItem.ToString());
                                myCommand.Parameters.AddWithValue("@vehicleid", Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["vehicle_id"].FormattedValue.ToString()));
                                myCommand.Parameters.AddWithValue("@userid", Convert.ToInt32(ds1.Tables[0].Rows[0]["user_id"].ToString()));
                                if (txtPromocode.Text == "") myCommand.Parameters.AddWithValue("@promocode", "NOPROMO");
                                else myCommand.Parameters.AddWithValue("@promocode", txtPromocode.Text);

                                string cmd4 = "SELECT card_no FROM carddetails WHERE user_id = '" + Convert.ToInt32(ds1.Tables[0].Rows[0]["user_id"].ToString()) + "';";
                                MySqlDataAdapter mysqlDataAdapter4 = new MySqlDataAdapter(cmd4, mysql);
                                DataSet ds4 = new DataSet();
                                mysqlDataAdapter4.Fill(ds4);

                                if (MessageBox.Show("Click OK to pay through your card: " + ds4.Tables[0].Rows[0]["card_no"].ToString()) == DialogResult.OK)
                                {

                                    if (1 == myCommand.ExecuteNonQuery()) tlStripLbl.Text = "Booking successful.";
                                    else tlStripLbl.Text = "Error in booking.";
                                }
                                else
                                {
                                    tlStripLbl.Text = "Booking cancelled.";
                                }
                            }
                        }
                        catch (Exception aex)
                        {
                            MessageBox.Show("Booking not successful.");
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (MySqlConnection mysql = new MySqlConnection(conString))
            {
                string cmd = string.Empty;
                //if (cmbLocation.SelectedItem.ToString() != "All locations")
                {
                    using (MySqlCommand myCommand = new MySqlCommand("ViewAvailableVehicles", mysql))
                    {
                        using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                        {
                            string location = (cmbLocation.SelectedItem.ToString() == "" || cmbLocation.SelectedItem.ToString() == "All locations") ? "NOLOCATION" : cmbLocation.SelectedItem.ToString();
                            myCommand.CommandType = CommandType.StoredProcedure;
                            myCommand.Parameters.AddWithValue("@locationid", location);
                            myCommand.Parameters.AddWithValue("@startdate", dtpStart.Value.Date.ToString("yyyy-MM-dd"));
                            myCommand.Parameters.AddWithValue("@enddate", dtpEnd.Value.Date.ToString("yyyy-MM-dd"));

                            DataSet ds = new DataSet();
                            mysqlDataAdapter.Fill(ds);
                            dataGridView2.DataSource = ds.Tables[0].DefaultView;
                        }
                    }
                }
                //else
                //{
                //    using (MySqlCommand myCommand = new MySqlCommand("ViewAvailableVehicles", mysql))
                //    {
                //        using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                //        {
                //            myCommand.CommandType = CommandType.StoredProcedure;
                //            myCommand.Parameters.AddWithValue("@startdate", dtpStart.Value.Date.ToString("yyyy-MM-dd"));
                //            myCommand.Parameters.AddWithValue("@enddate", dtpEnd.Value.Date.ToString("yyyy-MM-dd"));

                //            DataSet ds = new DataSet();
                //            mysqlDataAdapter.Fill(ds);
                //            dataGridView2.DataSource = ds.Tables[0].DefaultView;
                //        }
                //    }
                //}
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string[] s = dataGridView2.SelectedRows[0].Cells["expiry_date"].Value.ToString().Split('/');
                string[] year = s[2].Split(' ');
                string date = year[0] + "-" + s[0] + "-" + s[1];
                conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                MySqlConnection mysql = new MySqlConnection(conString);
                mysql.Open();

                string cmd1 = "SELECT user_id FROM usercredentials WHERE user_name = '" + Program.user_name + "';";
                MySqlDataAdapter mysqlDataAdapter1 = new MySqlDataAdapter(cmd1, mysql);
                DataSet ds1 = new DataSet();
                mysqlDataAdapter1.Fill(ds1);

                string query = "UPDATE carddetails SET ";
                query += "card_no = '" + dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                query += "', name_on_card = '" + dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                query += "', expiry_date = '" + date;
                query += "', cvv = '" + dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                query += "', address_line_1 = '" + dataGridView2.SelectedRows[0].Cells["address_line_1"].Value.ToString();
                query += "', address_line_2 = '" + dataGridView2.SelectedRows[0].Cells["address_line_2"].Value.ToString();
                query += "', zipcode_cd = '" + dataGridView2.SelectedRows[0].Cells["zipcode_cd"].Value.ToString();
                query += "' WHERE user_id = '" + Convert.ToInt32(ds1.Tables[0].Rows[0]["user_id"].ToString()) + "';";
                
                MySqlCommand myCommand = new MySqlCommand(query, mysql);
                
                if (1 == myCommand.ExecuteNonQuery()) tlStripLbl.Text = "Selected entry updated successfully.";
                else tlStripLbl.Text = "Error in updating the selected entry.";

                mysql.Close();
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (MySqlConnection mysql = new MySqlConnection(conString))
            {
                mysql.Open();
                string cmd1 = "SELECT user_id FROM usercredentials WHERE user_name = '" + Program.user_name + "';";
                MySqlDataAdapter mysqlDataAdapter1 = new MySqlDataAdapter(cmd1, mysql);
                DataSet ds1 = new DataSet();
                mysqlDataAdapter1.Fill(ds1);

                using (MySqlCommand myCommand = new MySqlCommand("ViewBookingHistory", mysql))
                {
                    using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                    {
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@userid", Convert.ToInt32(ds1.Tables[0].Rows[0]["user_id"].ToString()));
                        DataSet ds = new DataSet();
                        mysqlDataAdapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0].DefaultView;
                        if (dataGridView2.Rows.Count <= 0 && dataGridView2.ColumnCount <= 0)
                            tlStripLbl.Text = "No vehicles booked.";
                    }
                }
            }
        }
        
        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            AddDiscount a = new AddDiscount();
            a.ShowDialog();
        }

        private void btnDeleteDiscount_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                using (MySqlConnection mysql = new MySqlConnection(conString))
                {
                    mysql.Open();

                    using (MySqlCommand myCommand = new MySqlCommand("DeletePromoCode", mysql))
                    {
                        using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                        {
                            myCommand.CommandType = CommandType.StoredProcedure;
                            myCommand.Parameters.AddWithValue("@promocode", item.Cells["promo_code"].Value);

                            if (1 == myCommand.ExecuteNonQuery()) tlStripLbl.Text = "Selected entry deleted successfully.";
                            else tlStripLbl.Text = "Error in deleting the selected entries.";

                            dataGridView1.Rows.RemoveAt(item.Index);
                        }
                    }

                    mysql.Close();
                }
            }
        }

        private void btnViewDiscount_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            string cmd = "SELECT * FROM discountdetails";
            MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(cmd, mysql);
            DataSet ds = new DataSet();
            mysqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            if (dataGridView1.Rows.Count > 0 && dataGridView1.ColumnCount > 0)
                tlStripLbl.Text = "All users loaded.";
            else
                tlStripLbl.Text = "No content available in User Database.";
        }
    }
}
