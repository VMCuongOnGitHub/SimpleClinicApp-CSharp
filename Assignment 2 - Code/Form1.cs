using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2___Code
{
    public partial class Form1 : Form
    {
        public int id = 4;
        public string avatarImagePath = Application.StartupPath + "\\Image\\";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
            TimePickerDoB.Format = DateTimePickerFormat.Custom;
            TimePickerDoB.CustomFormat = "dd/MM/yyyy";
        }

        void InitData()
        {
            Patient patientZero = new Patient(1, avatarImagePath + "1.png", "Margaret W. Sinnott", "11/20/1948", "Female","4725 Shady Pines Drive Owensboro, KY 42301", "0965  395  999");
            Patient patientNumberOne = new Patient(2, avatarImagePath + "2.png", "Lupe D. Archibald", "03/05/1945", "Female", "3835 Spruce Drive New Wilmington, PA 16142", "0919  333 666");
            Patient patientNumberTwo = new Patient(3, avatarImagePath + "3.png", "Heather R. Richardson", "06/01/1946", "Male", "2780 Lincoln Street Hightstown, NJ 08520", "0999  123  456");

            ListBAllPatients.Items.Add(patientZero);
            ListBAllPatients.Items.Add(patientNumberOne);
            ListBAllPatients.Items.Add(patientNumberTwo);
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            // Add ID.
            int patientID = id;
            id++;

            // Add avatar.
            string patientAvatar = avatarImagePath + patientID.ToString() + ".png";

            // Add Name.
            string patientName = "";
            if (TxtBFullName.Text.Length > 0)
            {
                patientName = TxtBFullName.Text;
            }
            else
            {
                MessageBox.Show("Must have a name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            // Add day of Birth.
            DateTime DoB = TimePickerDoB.Value;
            string patientDayOfBirth = DoB.Month + "/" + DoB.Day + "/" + DoB.Year;

            // Gender.
            string patientGender = "";
            if (RbtnMale.Checked) patientGender = RbtnMale.Text;
            if (RbtnFemale.Checked) patientGender = RbtnFemale.Text;
            if (RbtnOther.Checked) patientGender = RbtnOther.Text;

            // Address.
            string patientAddress = TxtBAddress.Text;

            // Telephone Number.
            string patientTelephoneNumber = TxtBTelephoneNumber.Text;

            // Add items in list view.
            Patient newPatient = new Patient(patientID, patientAvatar, patientName, patientDayOfBirth, patientGender, patientAddress, patientTelephoneNumber);

            // Add items in listbox.
            ListBAllPatients.Items.Add(newPatient);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Patient updatePatient = (Patient)ListBAllPatients.SelectedItem;

            updatePatient.Name = TxtBFullName.Text;

            updatePatient.Address = TxtBAddress.Text;

            updatePatient.TelephoneNumber = TxtBTelephoneNumber.Text;

            DateTime DoB = TimePickerDoB.Value;
            string patientDayOfBirth = DoB.Month + "/" + DoB.Day + "/" + DoB.Year;
            updatePatient.DayOfBirth = patientDayOfBirth;

            if (RbtnMale.Checked)
            {
                updatePatient.Gender = RbtnMale.Text;
            }
            else if (RbtnFemale.Checked)
            {
                updatePatient.Gender = RbtnFemale.Text;
            }
            else
            {
                updatePatient.Gender = RbtnOther.Text;
            }

            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int deleteItemListB = ListBAllPatients.SelectedIndex;
            ListBAllPatients.Items.RemoveAt(deleteItemListB);

            string deleteAvatarPath = avatarImagePath + (deleteItemListB + 1).ToString() + ".png";
            System.IO.File.Delete(deleteAvatarPath);

            MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TxtBSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string patientName = TxtBSearch.Text;
                for (int i = 0; i < ListBAllPatients.Items.Count; i++)
                {
                    Patient patientSearch = (Patient)ListBAllPatients.Items[i];
                    if (patientName == patientSearch.Name)
                    {
                        ListBAllPatients.SelectedIndex = i;
                        return;
                    }
                }

                ListBAllPatients.SelectedIndex = -1;
                MessageBox.Show("Error 404: Patient Not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ListBAllPatients_DoubleClick(object sender, EventArgs e)
        {
            if (ListBAllPatients.SelectedIndex != -1)
            {
                BtnDelete.Enabled = true;
                BtnUpdate.Enabled = true;

                // Enable Editting.
                TxtBFullName.ReadOnly = false;
                TimePickerDoB.Enabled = true;
                RbtnMale.Enabled = true;
                RbtnFemale.Enabled = true;
                RbtnOther.Enabled = true;
                TxtBAddress.ReadOnly = false;
                TxtBTelephoneNumber.ReadOnly = false;

                ShowInforOnTextBox();

                TxtBFullName.Focus();
            }
        }

        private void ListBAllPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBAllPatients.SelectedIndex != -1)
            {
                ShowInforOnTextBox();
            }

            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;

            // Disable Editting.
            TxtBFullName.ReadOnly = true;
            TimePickerDoB.Enabled = false;
            RbtnMale.Enabled = false;
            RbtnFemale.Enabled = false;
            RbtnOther.Enabled = false;
            TxtBAddress.ReadOnly = true;
            TxtBTelephoneNumber.ReadOnly = true;
        }

        private void TxtBTelephoneNumber_TextChanged(object sender, EventArgs e)
        {
            string telephoneNumber = TxtBTelephoneNumber.Text;

            if (telephoneNumber.Length == 4 || telephoneNumber.Length == 9)
            {
                TxtBTelephoneNumber.Text = telephoneNumber + "  ";
            }
            else if (telephoneNumber.Length == 15)
            {
                // Delete the 16th charactor.
                TxtBTelephoneNumber.Text = telephoneNumber.Substring(0, telephoneNumber.Length - 1);
                MessageBox.Show("No more than 10 digits", "Valide Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TxtBTelephoneNumber.Select(TxtBTelephoneNumber.Text.Length, 0);
            }
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Please select an Image";
            fileDialog.Filter = "png (*.png) | *.png";


            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.CheckFileExists) {
                    string correctFileName = System.IO.Path.GetFileName(fileDialog.FileName);

                    string saveFile = avatarImagePath + id.ToString() + "." + correctFileName.Substring(correctFileName.Length - 3);

                    System.IO.File.Copy(fileDialog.FileName, saveFile);
                    PictBAvatar.Image = new Bitmap(fileDialog.FileName);


                }
            }
        }

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            PictBAvatar.Image = null;
        }

        // Sub-modules.
        void ShowInforOnTextBox()
        {
            Patient selectedPatient = (Patient)ListBAllPatients.SelectedItem;

            if (File.Exists(selectedPatient.AvatarImage))
            {
                PictBAvatar.Load(selectedPatient.AvatarImage);
            }
                   

            LblID.Text = Convert.ToString(selectedPatient.Id);

            TxtBFullName.Text = selectedPatient.Name;

            DateTime selectedDoB = Convert.ToDateTime(selectedPatient.DayOfBirth);
            TimePickerDoB.Value = selectedDoB;

            switch (selectedPatient.Gender)
            {
                case "Male":
                    RbtnMale.Checked = true;
                    break;

                case "Female":
                    RbtnFemale.Checked = true;
                    break;

                case "Other":
                    RbtnOther.Checked = true;
                    break;
            }

            TxtBAddress.Text = selectedPatient.Address;
            TxtBTelephoneNumber.Text = selectedPatient.TelephoneNumber;
        }

    }
}
