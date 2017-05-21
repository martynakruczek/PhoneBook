namespace PhoneBook
{
    partial class AddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.birthDatelabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addContactLabel = new System.Windows.Forms.Label();
            this.editAvatar = new System.Windows.Forms.LinkLabel();
            this.contactAvatar = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.errorNameLabel = new System.Windows.Forms.Label();
            this.errorPhoneNumberLabel = new System.Windows.Forms.Label();
            this.errorEmailLabel = new System.Windows.Forms.Label();
            this.errorBirthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.SystemColors.Window;
            this.firstName.Location = new System.Drawing.Point(78, 83);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(149, 20);
            this.firstName.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(265, 83);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(137, 20);
            this.lastName.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(78, 134);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(149, 20);
            this.email.TabIndex = 2;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(78, 182);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(149, 20);
            this.phoneNumber.TabIndex = 3;
            this.phoneNumber.Text = "+";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(78, 294);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(149, 20);
            this.street.TabIndex = 5;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(78, 339);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(149, 20);
            this.city.TabIndex = 6;
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(265, 339);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(137, 20);
            this.postalCode.TabIndex = 7;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNamelabel.Location = new System.Drawing.Point(262, 67);
            this.lastNamelabel.Name = "lastNameLabel";
            this.lastNamelabel.Size = new System.Drawing.Size(59, 13);
            this.lastNamelabel.TabIndex = 8;
            this.lastNamelabel.Text = "Last name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Location = new System.Drawing.Point(75, 67);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First name:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.Location = new System.Drawing.Point(75, 166);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.phoneNumberLabel.TabIndex = 10;
            this.phoneNumberLabel.Text = "Phone number:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(75, 118);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "E-mail:";
            // 
            // birthDatelabel
            // 
            this.birthDatelabel.AutoSize = true;
            this.birthDatelabel.BackColor = System.Drawing.Color.Transparent;
            this.birthDatelabel.Location = new System.Drawing.Point(75, 207);
            this.birthDatelabel.Name = "birthDatelabel";
            this.birthDatelabel.Size = new System.Drawing.Size(55, 13);
            this.birthDatelabel.TabIndex = 12;
            this.birthDatelabel.Text = "Birth date:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressLabel.Location = new System.Drawing.Point(124, 249);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 15);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Address";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.BackColor = System.Drawing.Color.Transparent;
            this.streetLabel.Location = new System.Drawing.Point(78, 278);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 14;
            this.streetLabel.Text = "Street:";
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.postalCodeLabel.Location = new System.Drawing.Point(262, 323);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(66, 13);
            this.postalCodeLabel.TabIndex = 15;
            this.postalCodeLabel.Text = "Postal code:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Location = new System.Drawing.Point(78, 323);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 16;
            this.cityLabel.Text = "City:";
            // 
            // addContactLabel
            // 
            this.addContactLabel.AutoSize = true;
            this.addContactLabel.BackColor = System.Drawing.Color.Transparent;
            this.addContactLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addContactLabel.Location = new System.Drawing.Point(119, 9);
            this.addContactLabel.Name = "addContactLabel";
            this.addContactLabel.Size = new System.Drawing.Size(196, 47);
            this.addContactLabel.TabIndex = 17;
            this.addContactLabel.Text = "Add Contact";
            // 
            // editAvatar
            // 
            this.editAvatar.ActiveLinkColor = System.Drawing.Color.Black;
            this.editAvatar.AutoSize = true;
            this.editAvatar.BackColor = System.Drawing.Color.Transparent;
            this.editAvatar.LinkColor = System.Drawing.Color.Black;
            this.editAvatar.Location = new System.Drawing.Point(304, 297);
            this.editAvatar.Name = "editAvatar";
            this.editAvatar.Size = new System.Drawing.Size(59, 13);
            this.editAvatar.TabIndex = 21;
            this.editAvatar.TabStop = true;
            this.editAvatar.Text = "Edit Avatar";
            this.editAvatar.VisitedLinkColor = System.Drawing.Color.Black;
            this.editAvatar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editAvatar_LinkClicked);
            // 
            // contactAvatar
            // 
            this.contactAvatar.BackColor = System.Drawing.Color.Transparent;
            this.contactAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactAvatar.BackgroundImage")));
            this.contactAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contactAvatar.ErrorImage = null;
            this.contactAvatar.Location = new System.Drawing.Point(265, 157);
            this.contactAvatar.Name = "contactAvatar";
            this.contactAvatar.Size = new System.Drawing.Size(137, 137);
            this.contactAvatar.TabIndex = 20;
            this.contactAvatar.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.SeaShell;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(314, 384);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.SeaShell;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(198, 384);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(78, 223);
            this.birthDate.MaxDate = new System.DateTime(2016, 4, 4, 0, 0, 0, 0);
            this.birthDate.MinDate = new System.DateTime(1917, 1, 1, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(149, 20);
            this.birthDate.TabIndex = 24;
            this.birthDate.Value = new System.DateTime(1917, 1, 1, 0, 0, 0, 0);
            // 
            // errorNameLabel
            // 
            this.errorNameLabel.AutoSize = true;
            this.errorNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorNameLabel.Location = new System.Drawing.Point(75, 362);
            this.errorNameLabel.Name = "errorNameLabel";
            this.errorNameLabel.Size = new System.Drawing.Size(132, 15);
            this.errorNameLabel.TabIndex = 25;
            this.errorNameLabel.Text = "* This field is obligatory";
            this.errorNameLabel.Visible = false;
            // 
            // errorPhoneNumberLabel
            // 
            this.errorPhoneNumberLabel.AutoSize = true;
            this.errorPhoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorPhoneNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.errorPhoneNumberLabel.Location = new System.Drawing.Point(78, 362);
            this.errorPhoneNumberLabel.Name = "errorPhoneNumberLabel";
            this.errorPhoneNumberLabel.Size = new System.Drawing.Size(159, 15);
            this.errorPhoneNumberLabel.TabIndex = 26;
            this.errorPhoneNumberLabel.Text = "* Phone number is incorrect";
            this.errorPhoneNumberLabel.Visible = false;
            // 
            // errorEmailLabel
            // 
            this.errorEmailLabel.AutoSize = true;
            this.errorEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.errorEmailLabel.Location = new System.Drawing.Point(75, 362);
            this.errorEmailLabel.Name = "errorEmailLabel";
            this.errorEmailLabel.Size = new System.Drawing.Size(113, 15);
            this.errorEmailLabel.TabIndex = 27;
            this.errorEmailLabel.Text = "* E-mail is incorrect";
            this.errorEmailLabel.Visible = false;
            // 
            // errorBirthLabel
            // 
            this.errorBirthLabel.AutoSize = true;
            this.errorBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorBirthLabel.ForeColor = System.Drawing.Color.Red;
            this.errorBirthLabel.Location = new System.Drawing.Point(75, 362);
            this.errorBirthLabel.Name = "errorBirthLabel";
            this.errorBirthLabel.Size = new System.Drawing.Size(135, 15);
            this.errorBirthLabel.TabIndex = 28;
            this.errorBirthLabel.Text = "* Enter correct birthdate";
            this.errorBirthLabel.Visible = false;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 419);
            this.Controls.Add(this.errorBirthLabel);
            this.Controls.Add(this.errorEmailLabel);
            this.Controls.Add(this.errorPhoneNumberLabel);
            this.Controls.Add(this.errorNameLabel);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editAvatar);
            this.Controls.Add(this.contactAvatar);
            this.Controls.Add(this.addContactLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.birthDatelabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNamelabel);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.city);
            this.Controls.Add(this.street);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddContact";
            this.Text = "Edit Contact";
            ((System.ComponentModel.ISupportInitialize)(this.contactAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox postalCode;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label birthDatelabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addContactLabel;
        private System.Windows.Forms.LinkLabel editAvatar;
        private System.Windows.Forms.PictureBox contactAvatar;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label errorNameLabel;
        private System.Windows.Forms.Label errorPhoneNumberLabel;
        private System.Windows.Forms.Label errorEmailLabel;
        private System.Windows.Forms.Label errorBirthLabel;
    }
}