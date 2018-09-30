namespace Assignment_2___Code
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblName = new System.Windows.Forms.Label();
            this.LblDoB = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblTelephoneNumber = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtBFullName = new System.Windows.Forms.TextBox();
            this.TxtBTelephoneNumber = new System.Windows.Forms.TextBox();
            this.TxtBAddress = new System.Windows.Forms.TextBox();
            this.RbtnMale = new System.Windows.Forms.RadioButton();
            this.RbtnFemale = new System.Windows.Forms.RadioButton();
            this.RbtnOther = new System.Windows.Forms.RadioButton();
            this.TimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBAllPatients = new System.Windows.Forms.ListBox();
            this.TxtBSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.PictBAvatar = new System.Windows.Forms.PictureBox();
            this.BtnAddImage = new System.Windows.Forms.Button();
            this.BtnRemoveImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictBAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(22, 32);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(54, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Full Name";
            // 
            // LblDoB
            // 
            this.LblDoB.AutoSize = true;
            this.LblDoB.Location = new System.Drawing.Point(22, 91);
            this.LblDoB.Name = "LblDoB";
            this.LblDoB.Size = new System.Drawing.Size(62, 13);
            this.LblDoB.TabIndex = 2;
            this.LblDoB.Text = "Day of Birth";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(22, 150);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(42, 13);
            this.LblGender.TabIndex = 3;
            this.LblGender.Text = "Gender";
            // 
            // LblTelephoneNumber
            // 
            this.LblTelephoneNumber.AutoSize = true;
            this.LblTelephoneNumber.Location = new System.Drawing.Point(312, 91);
            this.LblTelephoneNumber.Name = "LblTelephoneNumber";
            this.LblTelephoneNumber.Size = new System.Drawing.Size(98, 13);
            this.LblTelephoneNumber.TabIndex = 6;
            this.LblTelephoneNumber.Text = "Telephone Number";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(312, 32);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(45, 13);
            this.LblAddress.TabIndex = 4;
            this.LblAddress.Text = "Address";
            // 
            // TxtBFullName
            // 
            this.TxtBFullName.Location = new System.Drawing.Point(94, 29);
            this.TxtBFullName.Name = "TxtBFullName";
            this.TxtBFullName.Size = new System.Drawing.Size(180, 20);
            this.TxtBFullName.TabIndex = 7;
            // 
            // TxtBTelephoneNumber
            // 
            this.TxtBTelephoneNumber.Location = new System.Drawing.Point(416, 88);
            this.TxtBTelephoneNumber.Name = "TxtBTelephoneNumber";
            this.TxtBTelephoneNumber.Size = new System.Drawing.Size(214, 20);
            this.TxtBTelephoneNumber.TabIndex = 11;
            this.TxtBTelephoneNumber.TextChanged += new System.EventHandler(this.TxtBTelephoneNumber_TextChanged);
            // 
            // TxtBAddress
            // 
            this.TxtBAddress.Location = new System.Drawing.Point(416, 29);
            this.TxtBAddress.Name = "TxtBAddress";
            this.TxtBAddress.Size = new System.Drawing.Size(214, 20);
            this.TxtBAddress.TabIndex = 10;
            // 
            // RbtnMale
            // 
            this.RbtnMale.AutoSize = true;
            this.RbtnMale.Location = new System.Drawing.Point(94, 145);
            this.RbtnMale.Name = "RbtnMale";
            this.RbtnMale.Size = new System.Drawing.Size(48, 17);
            this.RbtnMale.TabIndex = 12;
            this.RbtnMale.TabStop = true;
            this.RbtnMale.Text = "Male";
            this.RbtnMale.UseVisualStyleBackColor = true;
            // 
            // RbtnFemale
            // 
            this.RbtnFemale.AutoSize = true;
            this.RbtnFemale.Location = new System.Drawing.Point(153, 145);
            this.RbtnFemale.Name = "RbtnFemale";
            this.RbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.RbtnFemale.TabIndex = 13;
            this.RbtnFemale.TabStop = true;
            this.RbtnFemale.Text = "Female";
            this.RbtnFemale.UseVisualStyleBackColor = true;
            // 
            // RbtnOther
            // 
            this.RbtnOther.AutoSize = true;
            this.RbtnOther.Location = new System.Drawing.Point(223, 145);
            this.RbtnOther.Name = "RbtnOther";
            this.RbtnOther.Size = new System.Drawing.Size(51, 17);
            this.RbtnOther.TabIndex = 14;
            this.RbtnOther.TabStop = true;
            this.RbtnOther.Text = "Other";
            this.RbtnOther.UseVisualStyleBackColor = true;
            // 
            // TimePickerDoB
            // 
            this.TimePickerDoB.CustomFormat = "dd/MM/YYYY";
            this.TimePickerDoB.Location = new System.Drawing.Point(94, 88);
            this.TimePickerDoB.Name = "TimePickerDoB";
            this.TimePickerDoB.Size = new System.Drawing.Size(180, 20);
            this.TimePickerDoB.TabIndex = 15;
            this.TimePickerDoB.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAddNew.Location = new System.Drawing.Point(315, 142);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(95, 23);
            this.BtnAddNew.TabIndex = 16;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(425, 142);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(95, 23);
            this.BtnUpdate.TabIndex = 17;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(535, 142);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 23);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Search by name";
            // 
            // ListBAllPatients
            // 
            this.ListBAllPatients.FormattingEnabled = true;
            this.ListBAllPatients.Location = new System.Drawing.Point(372, 283);
            this.ListBAllPatients.Name = "ListBAllPatients";
            this.ListBAllPatients.Size = new System.Drawing.Size(258, 251);
            this.ListBAllPatients.TabIndex = 24;
            this.ListBAllPatients.SelectedIndexChanged += new System.EventHandler(this.ListBAllPatients_SelectedIndexChanged);
            this.ListBAllPatients.DoubleClick += new System.EventHandler(this.ListBAllPatients_DoubleClick);
            // 
            // TxtBSearch
            // 
            this.TxtBSearch.Location = new System.Drawing.Point(369, 256);
            this.TxtBSearch.Name = "TxtBSearch";
            this.TxtBSearch.Size = new System.Drawing.Size(260, 20);
            this.TxtBSearch.TabIndex = 25;
            this.TxtBSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(91, 197);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(15, 13);
            this.LblID.TabIndex = 27;
            this.LblID.Text = "id";
            // 
            // PictBAvatar
            // 
            this.PictBAvatar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PictBAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictBAvatar.InitialImage")));
            this.PictBAvatar.Location = new System.Drawing.Point(25, 256);
            this.PictBAvatar.Name = "PictBAvatar";
            this.PictBAvatar.Size = new System.Drawing.Size(150, 150);
            this.PictBAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictBAvatar.TabIndex = 28;
            this.PictBAvatar.TabStop = false;
            // 
            // BtnAddImage
            // 
            this.BtnAddImage.Location = new System.Drawing.Point(189, 272);
            this.BtnAddImage.Name = "BtnAddImage";
            this.BtnAddImage.Size = new System.Drawing.Size(119, 41);
            this.BtnAddImage.TabIndex = 29;
            this.BtnAddImage.Text = "Add Image";
            this.BtnAddImage.UseVisualStyleBackColor = true;
            this.BtnAddImage.Click += new System.EventHandler(this.BtnAddImage_Click);
            // 
            // BtnRemoveImage
            // 
            this.BtnRemoveImage.Location = new System.Drawing.Point(189, 319);
            this.BtnRemoveImage.Name = "BtnRemoveImage";
            this.BtnRemoveImage.Size = new System.Drawing.Size(119, 41);
            this.BtnRemoveImage.TabIndex = 30;
            this.BtnRemoveImage.Text = "Remove Image";
            this.BtnRemoveImage.UseVisualStyleBackColor = true;
            this.BtnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Only accept png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRemoveImage);
            this.Controls.Add(this.BtnAddImage);
            this.Controls.Add(this.PictBAvatar);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBSearch);
            this.Controls.Add(this.ListBAllPatients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.TimePickerDoB);
            this.Controls.Add(this.RbtnOther);
            this.Controls.Add(this.RbtnFemale);
            this.Controls.Add(this.RbtnMale);
            this.Controls.Add(this.TxtBTelephoneNumber);
            this.Controls.Add(this.TxtBAddress);
            this.Controls.Add(this.TxtBFullName);
            this.Controls.Add(this.LblTelephoneNumber);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblDoB);
            this.Controls.Add(this.LblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictBAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDoB;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblTelephoneNumber;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxtBFullName;
        private System.Windows.Forms.TextBox TxtBTelephoneNumber;
        private System.Windows.Forms.TextBox TxtBAddress;
        private System.Windows.Forms.RadioButton RbtnMale;
        private System.Windows.Forms.RadioButton RbtnFemale;
        private System.Windows.Forms.RadioButton RbtnOther;
        private System.Windows.Forms.DateTimePicker TimePickerDoB;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBAllPatients;
        private System.Windows.Forms.TextBox TxtBSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.PictureBox PictBAvatar;
        private System.Windows.Forms.Button BtnAddImage;
        private System.Windows.Forms.Button BtnRemoveImage;
        private System.Windows.Forms.Label label3;
    }
}

