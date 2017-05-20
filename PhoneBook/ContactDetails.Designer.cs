namespace PhoneBook
{
    partial class ContactDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactDetails));
            this.label10 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.contactAvatar = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.postalCode = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(111, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 47);
            this.label10.TabIndex = 18;
            this.label10.Text = "Contact Details";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.SeaShell;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(315, 382);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 43;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // contactAvatar
            // 
            this.contactAvatar.BackColor = System.Drawing.Color.Transparent;
            this.contactAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactAvatar.BackgroundImage")));
            this.contactAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contactAvatar.ErrorImage = null;
            this.contactAvatar.Location = new System.Drawing.Point(253, 162);
            this.contactAvatar.Name = "contactAvatar";
            this.contactAvatar.Size = new System.Drawing.Size(137, 137);
            this.contactAvatar.TabIndex = 41;
            this.contactAvatar.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(79, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(262, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Postal code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(79, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Street:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(132, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(76, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Birth date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(76, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(77, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Phone number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(76, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(262, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Last name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.Color.Transparent;
            this.firstName.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstName.Location = new System.Drawing.Point(75, 78);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(48, 26);
            this.firstName.TabIndex = 44;
            this.firstName.Text = "Jane";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.email.Location = new System.Drawing.Point(74, 123);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(108, 26);
            this.email.TabIndex = 45;
            this.email.Text = "123@345.pl";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneNumber.Location = new System.Drawing.Point(78, 162);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(111, 26);
            this.phoneNumber.TabIndex = 46;
            this.phoneNumber.Text = "123456789";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastName.Location = new System.Drawing.Point(260, 78);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(40, 26);
            this.lastName.TabIndex = 47;
            this.lastName.Text = "Doe";
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.BackColor = System.Drawing.Color.Transparent;
            this.birthDate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.birthDate.Location = new System.Drawing.Point(75, 207);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(108, 26);
            this.birthDate.TabIndex = 48;
            this.birthDate.Text = "01.01.2000";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.BackColor = System.Drawing.Color.Transparent;
            this.street.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.street.Location = new System.Drawing.Point(77, 289);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(59, 26);
            this.street.TabIndex = 49;
            this.street.Text = "st Xyz";
            // 
            // postalCode
            // 
            this.postalCode.AutoSize = true;
            this.postalCode.BackColor = System.Drawing.Color.Transparent;
            this.postalCode.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postalCode.Location = new System.Drawing.Point(260, 335);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(88, 26);
            this.postalCode.TabIndex = 50;
            this.postalCode.Text = "123-346";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.city.Location = new System.Drawing.Point(77, 335);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(86, 26);
            this.city.TabIndex = 51;
            this.city.Text = "New York";
            // 
            // ContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 419);
            this.Controls.Add(this.city);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.street);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.contactAvatar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContactDetails";
            this.Text = "Contact Details";
            this.Load += new System.EventHandler(this.ContactDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox contactAvatar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label postalCode;
        private System.Windows.Forms.Label city;
    }
}