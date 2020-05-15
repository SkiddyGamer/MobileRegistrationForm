using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            fieldName.Text = "Name";
            fieldName.Tag = "Name";
            fieldName.ForeColor = Color.Gray;

            fieldSurname.Text = "Surname";
            fieldSurname.Tag = "Surname";
            fieldSurname.ForeColor = Color.Gray;

            fieldEmail.Text = "Enter your E-mail here!";
            fieldEmail.Tag = "Enter your E-mail here!";
            fieldEmail.ForeColor = Color.Gray;

            fieldPassword.Text = "Password";
            fieldPassword.Tag = "Password";
            fieldPassword.ForeColor = Color.Gray;

            fieldRepeat.Text = "Password repeat";
            fieldRepeat.Tag = "Password repeat";
            fieldRepeat.ForeColor = Color.Gray;
        }

        private void Field_Enter(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if(field.Text == (string)field.Tag)
            {
                field.Text = string.Empty;
                field.ForeColor = Color.Black;

                if ((string)field.Tag == "Password" || (string)field.Tag == "Password repeat")
                {
                    field.PasswordChar = '*';
                }
            }
        }

        private void Field_Leave(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if(field.Text == string.Empty)
            {
                field.Text = (string)field.Tag;
                field.ForeColor = Color.Gray;

                if ((string)field.Tag == "Password" || (string)field.Tag == "Password repeat")
                {
                    field.PasswordChar = '\0';
                }
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                fieldPassword.PasswordChar = '\0';
                fieldRepeat.PasswordChar = '\0';
            }
            else
            {
                if(fieldPassword.Text != (string)fieldPassword.Tag)
                {
                    fieldPassword.PasswordChar = '*';
                }
                if(fieldRepeat.Text != (string)fieldRepeat.Tag)
                {
                    fieldRepeat.PasswordChar = '*'; 
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if(fieldPassword.Text != fieldRepeat.Text)
            {
                //passwords are not equal
                fieldPassword.ForeColor = Color.Red;
                fieldRepeat.ForeColor = Color.Red;
                return;
            }
            MessageBox.Show("User registered");

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if(fieldPassword.Text == fieldRepeat.Text)
            {
                fieldPassword.ForeColor = Color.Black;
                fieldRepeat.ForeColor = Color.Black;
            }
        }
    }
}
