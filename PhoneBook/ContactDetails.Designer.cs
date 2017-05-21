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
            this.contactDetailsLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.contactAvatar = new System.Windows.Forms.PictureBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
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
            // contactDetailsLabel
            // 
            this.contactDetailsLabel.AutoSize = true;
            this.contactDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactDetailsLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contactDetailsLabel.Location = new System.Drawing.Point(111, 9);
            this.contactDetailsLabel.Name = "contactDetailsLabel";
            this.contactDetailsLabel.Size = new System.Drawing.Size(230, 47);
            this.contactDetailsLabel.TabIndex = 18;
            this.contactDetailsLabel.Text = "Contact Details";
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
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Location = new System.Drawing.Point(79, 322);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 40;
            this.cityLabel.Text = "City:";
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.postalCodeLabel.Location = new System.Drawing.Point(262, 322);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(66, 13);
            this.postalCodeLabel.TabIndex = 39;
            this.postalCodeLabel.Text = "Postal code:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.BackColor = System.Drawing.Color.Transparent;
            this.streetLabel.Location = new System.Drawing.Point(79, 276);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 38;
            this.streetLabel.Text = "Street:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressLabel.Location = new System.Drawing.Point(132, 245);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 15);
            this.addressLabel.TabIndex = 37;
            this.addressLabel.Text = "Address";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthDateLabel.Location = new System.Drawing.Point(76, 194);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(55, 13);
            this.birthDateLabel.TabIndex = 36;
            this.birthDateLabel.Text = "Birth date:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(76, 110);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 35;
            this.emailLabel.Text = "E-mail:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.Location = new System.Drawing.Point(77, 149);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.phoneNumberLabel.TabIndex = 34;
            this.phoneNumberLabel.Text = "Phone number:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Location = new System.Drawing.Point(76, 65);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 33;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Location = new System.Drawing.Point(262, 65);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 32;
            this.lastNameLabel.Text = "Last name:";
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
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.contactDetailsLabel);
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

        private System.Windows.Forms.Label contactDetailsLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox contactAvatar;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
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