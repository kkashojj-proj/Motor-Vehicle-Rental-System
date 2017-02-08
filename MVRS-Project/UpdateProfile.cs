using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVRS_Project
{
    public partial class UpdateProfile : Form
    {
        string conString;

        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            mysql.Open();

            string query = "SELECT email, address_line_1, address_line_2, z.city, z.state, z.zipcode, contact_num_1, contact_num_2 FROM user u INNER JOIN usercredentials uc ON u.user_id = uc.user_id INNER JOIN zipcodes z ON z.zipcode = u.zipcode WHERE user_name = '" + Program.user_name + "';";
            string query1 = "SELECT password FROM usercredentials WHERE user_name = '" + Program.user_name + "';";
            MySqlCommand myCommand = new MySqlCommand(query, mysql);
            MySqlCommand myCommand1 = new MySqlCommand(query1, mysql);
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(myCommand);
            MySqlDataAdapter da1 = new MySqlDataAdapter(myCommand1);
            da.Fill(ds);
            da1.Fill(ds1);

            txtPasswd.Text = ds1.Tables[0].Rows[0]["password"].ToString();
            txtEmailId.Text = ds.Tables[0].Rows[0]["email"].ToString();
            txtAddress1.Text = ds.Tables[0].Rows[0]["address_line_1"].ToString();
            txtAddress2.Text = ds.Tables[0].Rows[0]["address_line_2"].ToString();
            txtCity.Text = ds.Tables[0].Rows[0]["city"].ToString();
            txtState.Text = ds.Tables[0].Rows[0]["state"].ToString();
            txtZip.Text = ds.Tables[0].Rows[0]["zipcode"].ToString();
            txtNum1.Text = ds.Tables[0].Rows[0]["contact_num_1"].ToString();
            txtNum2.Text = ds.Tables[0].Rows[0]["contact_num_2"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                MySqlCommand myCommand2 = new MySqlCommand(cmd2, mysql);
                myCommand2.Parameters.AddWithValue("@city", txtCity.Text);
                myCommand2.Parameters.AddWithValue("@state", txtState.Text);
                myCommand2.Parameters.AddWithValue("@zipcode", txtZip.Text);

                myCommand2.ExecuteNonQuery();
            }

            string query = "UPDATE user SET ";
            query += "email = '" + txtEmailId.Text;
            query += "', address_line_1 = '" + txtAddress1.Text;
            query += "', address_line_2 = '" + txtAddress2.Text;
            query += "', zipcode = '" + txtZip.Text;
            query += "', contact_num_1 = '" + txtNum1.Text;
            query += "', contact_num_2 = '" + txtNum2.Text + "' WHERE user_id like (SELECT user_id FROM usercredentials WHERE user_name = '" + Program.user_name + "');";

            string query1 = "UPDATE usercredentials SET password = '" + txtPasswd.Text + "' WHERE user_name = '" + Program.user_name + "';";
            
            MySqlCommand myCommand = new MySqlCommand(query, mysql);
            MySqlCommand myCommand1 = new MySqlCommand(query1, mysql);

            if ((myCommand.ExecuteNonQuery() == 1) && (myCommand1.ExecuteNonQuery() == 1)) { MessageBox.Show("Selected entry updated successfully."); }
            else { MessageBox.Show("Error in updating the selected entry."); }

            mysql.Close();
        }
    }
}
