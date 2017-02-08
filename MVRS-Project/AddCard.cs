using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MVRS_Project
{
    public partial class AddCard : Form
    {
        string conString;
        public AddCard()
        {
            InitializeComponent();
        }

        private void AddCard_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            string query = "INSERT INTO carddetails (user_id, card_no, name_on_card, expiry_date, cvv, address_line_1, address_line_2, zipcode_cd)";
            query += " VALUES (@user_id, @card_no, @name_on_card, @expiry_date, @cvv, @address_line_1, @address_line_2, @zipcode)";

            mysql.Open();

            string cmd1 = "SELECT user_id FROM usercredentials WHERE user_name = '" + Program.user_name + "';";
            MySqlDataAdapter mysqlDataAdapter1 = new MySqlDataAdapter(cmd1, mysql);
            DataSet ds1 = new DataSet();
            mysqlDataAdapter1.Fill(ds1);

            MySqlCommand myCommand = new MySqlCommand(query, mysql);
            myCommand.Parameters.AddWithValue("@user_id", ds1.Tables[0].Rows[0]["user_id"].ToString());
            myCommand.Parameters.AddWithValue("@card_no", txtCardNumber.Text);
            myCommand.Parameters.AddWithValue("@name_on_card", txtCardOnName.Text);
            myCommand.Parameters.AddWithValue("@expiry_date", txtExpiryDate.Value.Date.ToString("yyyy-MM-dd"));
            myCommand.Parameters.AddWithValue("@cvv", txtCvv.Text);
            myCommand.Parameters.AddWithValue("@address_line_1", txtAddress1.Text);
            myCommand.Parameters.AddWithValue("@address_line_2", txtAddress2.Text);
            myCommand.Parameters.AddWithValue("@zipcode", txtZipcode.Text);

            // ... other parameters
            if (1 == myCommand.ExecuteNonQuery())
            {
                MessageBox.Show("Entry added!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in entry added.");
            }
            mysql.Close();
        }
    }
}
