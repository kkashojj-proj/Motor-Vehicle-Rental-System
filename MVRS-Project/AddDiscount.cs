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
    public partial class AddDiscount : Form
    {
        string conString;
        public AddDiscount()
        {
            InitializeComponent();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection mysql = new MySqlConnection(conString);
            string query = "INSERT INTO discountdetails (promo_code, description, discount_percentage)";
            query += " VALUES (@promocode, @description, @discount)";

            mysql.Open();
            
            MySqlCommand myCommand = new MySqlCommand(query, mysql);
            myCommand.Parameters.AddWithValue("@promocode", txtPromo.Text);
            myCommand.Parameters.AddWithValue("@description", txtDesc.Text);
            myCommand.Parameters.AddWithValue("@discount", Convert.ToInt32(txtDiscount.Text));
            
            // ... other parameters
            if (1 == myCommand.ExecuteNonQuery())
            {
                MessageBox.Show("Entry added!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in entry.");
            }
            mysql.Close();
        }
    }
}
