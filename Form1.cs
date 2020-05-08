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
            fieldEmail.Tag = "Email";
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
            }
        }
    }
}
