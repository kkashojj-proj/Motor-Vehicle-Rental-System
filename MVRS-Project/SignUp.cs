using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MVRS_Project
{
    public partial class SignUp : Form
    {
        string conString;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            mysql.Open();
            string cmd1 = "SELECT city FROM zipcodes WHERE zipcode = '" + txtZip.Text + "';";
            MySqlDataAdapter mysqlDataAdapter1 = new MySqlDataAdapter(cmd1, mysql);
            DataSet ds1 = new DataSet();
            mysqlDataAdapter1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count <= 0)
            {
                string cmd2 = "INSERT INTO zipcodes (zipcode, city, state) VALUES (@zipcode, @city, @state)";
                MySqlCommand myCommand1 = new MySqlCommand(cmd2, mysql);
                myCommand1.Parameters.AddWithValue("@city", txtCity.Text);
                myCommand1.Parameters.AddWithValue("@state", txtState.Text);
                myCommand1.Parameters.AddWithValue("@zipcode", txtZip.Text);

                myCommand1.ExecuteNonQuery();
            }
            
            string query = "INSERT INTO user (first_name, last_name, email, license_no, date_of_birth, address_line_1, address_line_2, contact_num_1, contact_num_2, zipcode)";
            query += " VALUES (@first_name, @last_name, @email, @license_no, @date_of_birth, @address_line_1, @address_line_2, @contact_num_1, @contact_num_2, @zipcode)";
            
            MySqlCommand myCommand = new MySqlCommand(query, mysql);
            myCommand.Parameters.AddWithValue("@first_name", txtFirstName.Text);
            myCommand.Parameters.AddWithValue("@last_name", txtLastName.Text);
            myCommand.Parameters.AddWithValue("@email", txtEmailId.Text);
            myCommand.Parameters.AddWithValue("@license_no", txtLicense.Text);
            myCommand.Parameters.AddWithValue("@date_of_birth", dtpDate.Value.Date.ToString("yyyy-MM-dd"));
            myCommand.Parameters.AddWithValue("@address_line_1", txtAddress1.Text);
            myCommand.Parameters.AddWithValue("@address_line_2", txtAddress2.Text);
            myCommand.Parameters.AddWithValue("@contact_num_1", txtNum1.Text);
            myCommand.Parameters.AddWithValue("@contact_num_2", (txtNum2.Text.ToString() == "" ? "" : txtNum2.Text.ToString()));
            myCommand.Parameters.AddWithValue("@zipcode", txtZip.Text);

            // ... other parameters
            if (1 == myCommand.ExecuteNonQuery())
            {
                lblSignupSucess.Show();
                
                // try catch needed here
                string cmd = "SELECT user_id FROM user where license_no like '" + txtLicense.Text + "';";
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(cmd, mysql);
                DataSet ds = new DataSet();
                mysqlDataAdapter.Fill(ds);

                int user_id = Convert.ToInt32(ds.Tables[0].Rows[0]["user_id"].ToString());

                string q = "INSERT INTO usercredentials (user_name, password, user_id, type_of_user)";
                q += " VALUES (@user_name, @password, @user_id, @type_of_user)";

                MySqlCommand myCmd = new MySqlCommand(q, mysql);
                myCmd.Parameters.AddWithValue("@user_name", txtUsrname.Text);
                myCmd.Parameters.AddWithValue("@password", txtPasswd.Text);
                myCmd.Parameters.AddWithValue("@user_id", user_id);
                myCmd.Parameters.AddWithValue("@type_of_user", "reg_user");

                myCmd.ExecuteNonQuery();
            }

            mysql.Close();
        }
    }
}
