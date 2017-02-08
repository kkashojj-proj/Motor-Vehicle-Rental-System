namespace MVRS_Project
{
    partial class AddCard
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
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblCvv = new System.Windows.Forms.Label();
            this.lblBillingAddress = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCardOnName = new System.Windows.Forms.TextBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(48, 44);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(92, 17);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(48, 80);
            this.lblCardName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(99, 17);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "Name on Card";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(48, 117);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(80, 17);
            this.lblExpiryDate.TabIndex = 2;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Location = new System.Drawing.Point(48, 154);
            this.lblCvv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(35, 17);
            this.lblCvv.TabIndex = 3;
            this.lblCvv.Text = "CVV";
            // 
            // lblBillingAddress
            // 
            this.lblBillingAddress.AutoSize = true;
            this.lblBillingAddress.Location = new System.Drawing.Point(48, 185);
            this.lblBillingAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillingAddress.Name = "lblBillingAddress";
            this.lblBillingAddress.Size = new System.Drawing.Size(107, 17);
            this.lblBillingAddress.TabIndex = 4;
            this.lblBillingAddress.Text = "Address Line 1:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(191, 36);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(132, 22);
            this.txtCardNumber.TabIndex = 5;
            // 
            // txtCardOnName
            // 
            this.txtCardOnName.Location = new System.Drawing.Point(191, 71);
            this.txtCardOnName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardOnName.Name = "txtCardOnName";
            this.txtCardOnName.Size = new System.Drawing.Size(132, 22);
            this.txtCardOnName.TabIndex = 6;
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(191, 144);
            this.txtCvv.Margin = new System.Windows.Forms.Padding(4);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(132, 22);
            this.txtCvv.TabIndex = 7;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(191, 181);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(132, 22);
            this.txtAddress1.TabIndex = 8;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpiryDate.Location = new System.Drawing.Point(191, 107);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(132, 22);
            this.txtExpiryDate.TabIndex = 9;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(130, 325);
            this.btnAddCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(136, 28);
            this.btnAddCard.TabIndex = 10;
            this.btnAddCard.Text = "Add Card";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(191, 211);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(132, 22);
            this.txtAddress2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Address Line 2:";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(191, 241);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(132, 22);
            this.txtZipcode.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Zipcode:";
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 388);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.txtCardOnName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblBillingAddress);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.lblCardNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCard";
            this.Text = "Add Card Details";
            this.Load += new System.EventHandler(this.AddCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.Label lblBillingAddress;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCardOnName;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.DateTimePicker txtExpiryDate;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label label2;
    }
}