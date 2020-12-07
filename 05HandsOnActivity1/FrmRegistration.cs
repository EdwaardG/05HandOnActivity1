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

//01000101 01001110 01000101 01001010 01001111 01010011 01000001

namespace _05HandsOnActivity1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Docupath = "C:/Users/EDWARD ENEJOSA/Desktop/";
            string StudNum = txtStudentNumber.Text;
            string fileExe = ".txt";
            string createDocu = Docupath + StudNum + fileExe;

            if (txtStudentNumber.Text == "")
            {
                errorProviderStudentNumber.SetError(txtStudentNumber, "Please enter a Student Number!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbProgram.Text == "")
            {
                errorProviderStudentNumber.Dispose();
                errorProviderProgram.SetError(cbProgram, "Please select a Program!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLastname.Text == "")
            {
                errorProviderProgram.Dispose();
                errorProviderLastname.SetError(txtLastname, "Please enter your Lastname!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtFirstname.Text == "")
            {
                errorProviderLastname.Dispose();
                errorProviderFirsname.SetError(txtFirstname, "Please enter your Firstname!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAge.Text == "")
            {
                errorProviderFirsname.Dispose();
                errorProviderAge.SetError(txtAge, "Please enter your Age!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbGender.Text == "")
            {
                errorProviderAge.Dispose();
                errorProviderGender.SetError(cbGender, "Please select a Gender!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtContactno.Text == "")
            {
                errorProviderGender.Dispose();
                errorProviderContactno.SetError(txtContactno, "Please enter a Program!");
                MessageBox.Show("Don't leave anything blank.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    errorProviderContactno.Dispose();

                    FileStream fileStream = new FileStream(createDocu, FileMode.OpenOrCreate);
                    StreamWriter outputFile = new StreamWriter(fileStream);

                    outputFile.WriteLine("Student No.: " + txtStudentNumber.Text);
                    outputFile.WriteLine("Full Name: " + txtLastname.Text + ", " + txtFirstname.Text + " " + txtMiddleinitial.Text + ".");
                    outputFile.WriteLine("Program: " + cbProgram.Text);
                    outputFile.WriteLine("Gender: " + cbGender.Text);
                    outputFile.WriteLine("Age: " + txtAge.Text);
                    outputFile.WriteLine("Birthday: " + dateTimePickerBday.Text);
                    outputFile.WriteLine("Contact: " + txtContactno.Text);
                    outputFile.Close();
                    fileStream.Close();
                    MessageBox.Show("Registration Complete.", "Message");
                }
                catch (Exception ed)
                {
                    MessageBox.Show(ed.Message);
                }
            }
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtContactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
