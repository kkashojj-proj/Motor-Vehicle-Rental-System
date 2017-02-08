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
    public partial class AddVehicle : Form
    {
        string conString;
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (MySqlConnection mysql = new MySqlConnection(conString))
            {
                using (MySqlCommand myCommand = new MySqlCommand("AddVehicle", mysql))
                {
                    using (MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(myCommand))
                    {
                        mysql.Open();
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@vehiclenumber", txtVNumber.Text);
                        myCommand.Parameters.AddWithValue("@mdl", txtModel.Text);
                        myCommand.Parameters.AddWithValue("@yr", txtYear.Text);
                        myCommand.Parameters.AddWithValue("@clr", txtColor.Text);
                        myCommand.Parameters.AddWithValue("@seatcapacity", Convert.ToInt32(txtSeatCapacity.Text));
                        myCommand.Parameters.AddWithValue("@isavailable", "yes");
                        myCommand.Parameters.AddWithValue("@costperday", Convert.ToInt32(txtCostperday.Text));
                        myCommand.Parameters.AddWithValue("@costpermile", Convert.ToInt32(txtCostpermile.Text));
                        myCommand.Parameters.AddWithValue("@ctgry", cmbCategory.SelectedItem.ToString());
                        myCommand.Parameters.AddWithValue("@cndtnd", cmbConditioned.SelectedItem.ToString());
                        myCommand.Parameters.AddWithValue("@locationid", cmbLocation.SelectedItem.ToString());

                        // ... other parameters
                        if (1 == myCommand.ExecuteNonQuery())
                        {
                            MessageBox.Show("Entry added!");
                            txtVNumber.Clear();
                            txtModel.Clear();
                            txtYear.Clear();
                            txtColor.Clear();
                            txtSeatCapacity.Clear();
                            txtCostperday.Clear();
                            txtCostpermile.Clear();

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
        }
    }
}
