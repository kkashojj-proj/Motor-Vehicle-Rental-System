namespace MVRS_Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblessCtrl = new MVRS_Project.TablessControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblUsrname = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.txtUsrname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnViewDiscount = new System.Windows.Forms.Button();
            this.btnDeleteDiscount = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbInsuranceType = new System.Windows.Forms.ComboBox();
            this.txtPromocode = new System.Windows.Forms.TextBox();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnCard = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnViewAvailblVehicls = new System.Windows.Forms.Button();
            this.btnLogoutRegUser = new System.Windows.Forms.Button();
            this.statusStr = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.tblessCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.statusStr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblessCtrl);
            this.panel1.Controls.Add(this.statusStr);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 543);
            this.panel1.TabIndex = 0;
            // 
            // tblessCtrl
            // 
            this.tblessCtrl.Controls.Add(this.tabPage1);
            this.tblessCtrl.Controls.Add(this.tabPage2);
            this.tblessCtrl.Controls.Add(this.tabPage3);
            this.tblessCtrl.Location = new System.Drawing.Point(5, 5);
            this.tblessCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.tblessCtrl.Name = "tblessCtrl";
            this.tblessCtrl.SelectedIndex = 0;
            this.tblessCtrl.Size = new System.Drawing.Size(864, 507);
            this.tblessCtrl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSignup);
            this.tabPage1.Controls.Add(this.lblUsrname);
            this.tabPage1.Controls.Add(this.lblPasswd);
            this.tabPage1.Controls.Add(this.btnSignin);
            this.tabPage1.Controls.Add(this.txtUsrname);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(856, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(424, 261);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(103, 34);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblUsrname
            // 
            this.lblUsrname.AutoSize = true;
            this.lblUsrname.Location = new System.Drawing.Point(292, 160);
            this.lblUsrname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsrname.Name = "lblUsrname";
            this.lblUsrname.Size = new System.Drawing.Size(81, 17);
            this.lblUsrname.TabIndex = 0;
            this.lblUsrname.Text = "Username :";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(292, 192);
            this.lblPasswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(77, 17);
            this.lblPasswd.TabIndex = 1;
            this.lblPasswd.Text = "Password :";
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(313, 261);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(103, 34);
            this.btnSignin.TabIndex = 4;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtUsrname
            // 
            this.txtUsrname.Location = new System.Drawing.Point(383, 158);
            this.txtUsrname.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsrname.Name = "txtUsrname";
            this.txtUsrname.Size = new System.Drawing.Size(167, 22);
            this.txtUsrname.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(383, 190);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnViewDiscount);
            this.tabPage2.Controls.Add(this.btnDeleteDiscount);
            this.tabPage2.Controls.Add(this.btnAddDiscount);
            this.tabPage2.Controls.Add(this.btnViewUsers);
            this.tabPage2.Controls.Add(this.btnUpdateVehicle);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnLoadDB);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnLogout);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(856, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnViewDiscount
            // 
            this.btnViewDiscount.Location = new System.Drawing.Point(600, 98);
            this.btnViewDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewDiscount.Name = "btnViewDiscount";
            this.btnViewDiscount.Size = new System.Drawing.Size(185, 28);
            this.btnViewDiscount.TabIndex = 17;
            this.btnViewDiscount.Text = "View all discount offers";
            this.btnViewDiscount.UseVisualStyleBackColor = true;
            this.btnViewDiscount.Click += new System.EventHandler(this.btnViewDiscount_Click);
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.Location = new System.Drawing.Point(460, 98);
            this.btnDeleteDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(132, 28);
            this.btnDeleteDiscount.TabIndex = 16;
            this.btnDeleteDiscount.Text = "Delete Discount";
            this.btnDeleteDiscount.UseVisualStyleBackColor = true;
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click_1);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(343, 98);
            this.btnAddDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(109, 28);
            this.btnAddDiscount.TabIndex = 15;
            this.btnAddDiscount.Text = "Add Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(176, 98);
            this.btnViewUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(159, 28);
            this.btnViewUsers.TabIndex = 7;
            this.btnViewUsers.Text = "View All Users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(301, 364);
            this.btnUpdateVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(127, 28);
            this.btnUpdateVehicle.TabIndex = 6;
            this.btnUpdateVehicle.Text = "Update Vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 364);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Location = new System.Drawing.Point(9, 98);
            this.btnLoadDB.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(159, 28);
            this.btnLoadDB.TabIndex = 3;
            this.btnLoadDB.Text = "View All Vehicles";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(744, 7);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbInsuranceType);
            this.tabPage3.Controls.Add(this.txtPromocode);
            this.tabPage3.Controls.Add(this.btnViewHistory);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.btnBook);
            this.tabPage3.Controls.Add(this.cmbLocation);
            this.tabPage3.Controls.Add(this.dtpEnd);
            this.tabPage3.Controls.Add(this.dtpStart);
            this.tabPage3.Controls.Add(this.btnCard);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.btnUpdateProfile);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.btnViewAvailblVehicls);
            this.tabPage3.Controls.Add(this.btnLogoutRegUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(856, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbInsuranceType
            // 
            this.cmbInsuranceType.FormattingEnabled = true;
            this.cmbInsuranceType.Items.AddRange(new object[] {
            "Liability",
            "Comprehensive"});
            this.cmbInsuranceType.Location = new System.Drawing.Point(177, 126);
            this.cmbInsuranceType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInsuranceType.Name = "cmbInsuranceType";
            this.cmbInsuranceType.Size = new System.Drawing.Size(148, 24);
            this.cmbInsuranceType.TabIndex = 14;
            // 
            // txtPromocode
            // 
            this.txtPromocode.Location = new System.Drawing.Point(710, 93);
            this.txtPromocode.Name = "txtPromocode";
            this.txtPromocode.Size = new System.Drawing.Size(134, 22);
            this.txtPromocode.TabIndex = 13;
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Location = new System.Drawing.Point(712, 126);
            this.btnViewHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(132, 28);
            this.btnViewHistory.TabIndex = 12;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(236, 8);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 28);
            this.button5.TabIndex = 11;
            this.button5.Text = "Update Card Details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 129);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "View Available Vehicles At location";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(594, 93);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(109, 28);
            this.btnBook.TabIndex = 9;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "All locations",
            "GraduateLane",
            "UTD",
            "UTN",
            "Ashford",
            "Ashville"});
            this.cmbLocation.Location = new System.Drawing.Point(9, 126);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(160, 24);
            this.cmbLocation.TabIndex = 8;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(177, 94);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(148, 22);
            this.dtpEnd.TabIndex = 7;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "";
            this.dtpStart.Location = new System.Drawing.Point(9, 94);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(160, 22);
            this.dtpStart.TabIndex = 6;
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(59, 8);
            this.btnCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(169, 28);
            this.btnCard.TabIndex = 5;
            this.btnCard.Text = "View Card Details";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 7);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Card Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(587, 7);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(149, 28);
            this.btnUpdateProfile.TabIndex = 3;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 176);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(835, 276);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnViewAvailblVehicls
            // 
            this.btnViewAvailblVehicls.Location = new System.Drawing.Point(333, 94);
            this.btnViewAvailblVehicls.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAvailblVehicls.Name = "btnViewAvailblVehicls";
            this.btnViewAvailblVehicls.Size = new System.Drawing.Size(229, 28);
            this.btnViewAvailblVehicls.TabIndex = 1;
            this.btnViewAvailblVehicls.Text = "View Available Vehicles";
            this.btnViewAvailblVehicls.UseVisualStyleBackColor = true;
            this.btnViewAvailblVehicls.Click += new System.EventHandler(this.btnViewAvailblVehicls_Click);
            // 
            // btnLogoutRegUser
            // 
            this.btnLogoutRegUser.Location = new System.Drawing.Point(744, 7);
            this.btnLogoutRegUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogoutRegUser.Name = "btnLogoutRegUser";
            this.btnLogoutRegUser.Size = new System.Drawing.Size(100, 28);
            this.btnLogoutRegUser.TabIndex = 0;
            this.btnLogoutRegUser.Text = "Logout";
            this.btnLogoutRegUser.UseVisualStyleBackColor = true;
            this.btnLogoutRegUser.Click += new System.EventHandler(this.btnLogoutRegUser_Click);
            // 
            // statusStr
            // 
            this.statusStr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar,
            this.tlStripLbl});
            this.statusStr.Location = new System.Drawing.Point(0, 521);
            this.statusStr.Name = "statusStr";
            this.statusStr.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStr.Size = new System.Drawing.Size(869, 22);
            this.statusStr.TabIndex = 6;
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // tlStripLbl
            // 
            this.tlStripLbl.Name = "tlStripLbl";
            this.tlStripLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 544);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Motor Vehicle Rental Service System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tblessCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.statusStr.ResumeLayout(false);
            this.statusStr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsrname;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsrname;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.StatusStrip statusStr;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private MVRS_Project.TablessControl tblessCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.ToolStripStatusLabel tlStripLbl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnViewAvailblVehicls;
        private System.Windows.Forms.Button btnLogoutRegUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnDeleteDiscount;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Button btnViewDiscount;
        private System.Windows.Forms.TextBox txtPromocode;
        private System.Windows.Forms.ComboBox cmbInsuranceType;
    }
}

