namespace MVRS_Project
{
    partial class AddVehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeatCapacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostperday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbConditioned = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCostpermile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Number :";
            // 
            // txtVNumber
            // 
            this.txtVNumber.Location = new System.Drawing.Point(157, 25);
            this.txtVNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtVNumber.Name = "txtVNumber";
            this.txtVNumber.Size = new System.Drawing.Size(209, 22);
            this.txtVNumber.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(157, 58);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(209, 22);
            this.txtModel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model :";
            // 
            // txtSeatCapacity
            // 
            this.txtSeatCapacity.Location = new System.Drawing.Point(157, 154);
            this.txtSeatCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeatCapacity.Name = "txtSeatCapacity";
            this.txtSeatCapacity.Size = new System.Drawing.Size(209, 22);
            this.txtSeatCapacity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seat Capacity :";
            // 
            // txtCostperday
            // 
            this.txtCostperday.Location = new System.Drawing.Point(157, 187);
            this.txtCostperday.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostperday.Name = "txtCostperday";
            this.txtCostperday.Size = new System.Drawing.Size(209, 22);
            this.txtCostperday.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cost per day :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Conditioned :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Two-wheeler",
            "Four-wheeler"});
            this.cmbCategory.Location = new System.Drawing.Point(157, 260);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(209, 24);
            this.cmbCategory.TabIndex = 13;
            // 
            // cmbConditioned
            // 
            this.cmbConditioned.FormattingEnabled = true;
            this.cmbConditioned.Items.AddRange(new object[] {
            "ac",
            "non-ac"});
            this.cmbConditioned.Location = new System.Drawing.Point(157, 301);
            this.cmbConditioned.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConditioned.Name = "cmbConditioned";
            this.cmbConditioned.Size = new System.Drawing.Size(209, 24);
            this.cmbConditioned.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 405);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 28);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Vehicle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(157, 90);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(209, 22);
            this.txtYear.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Year :";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(157, 122);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(209, 22);
            this.txtColor.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Color :";
            // 
            // txtCostpermile
            // 
            this.txtCostpermile.Location = new System.Drawing.Point(157, 219);
            this.txtCostpermile.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostpermile.Name = "txtCostpermile";
            this.txtCostpermile.Size = new System.Drawing.Size(209, 22);
            this.txtCostpermile.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cost per mile :";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "graduatelane",
            "utd",
            "utn",
            "ashford",
            "ashville"});
            this.cmbLocation.Location = new System.Drawing.Point(157, 342);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(209, 24);
            this.cmbLocation.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 345);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Location :";
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 446);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCostpermile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbConditioned);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCostperday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSeatCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVNumber;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeatCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCostperday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbConditioned;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCostpermile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label11;
    }
}