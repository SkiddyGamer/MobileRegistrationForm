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
            fieldName.ForeColor = Color.Gray;

            fieldSurname.Text = "Surname";
            fieldSurname.ForeColor = Color.Gray;

            fieldEmail.Text = "Enter your E-mail here!";
            fieldEmail.ForeColor = Color.Gray;

            fieldPassword.Text = "Password";
            fieldPassword.ForeColor = Color.Gray;

            fieldRepeat.Text = "Password repeat";
            fieldRepeat.ForeColor = Color.Gray;
        }
    }
}
