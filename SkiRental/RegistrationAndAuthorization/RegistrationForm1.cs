using SkiRental.RegistrationAndAuthorization;
using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SkiRental
{
    public partial class RegistrationForm1 : Form
    {
        public RegistrationForm1()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != confirmationTextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else if (loginTextBox.Text != "" && passwordTextBox.Text != "" && confirmationTextBox.Text != "")
            {
                this.Hide();
                RegistrationForm2 form2 = new RegistrationForm2(loginTextBox.Text, passwordTextBox.Text);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Одно или несколько полей незаполнены!");
            }
        }

        private void hidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (hidePassword.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = true;
                confirmationTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
                confirmationTextBox.UseSystemPasswordChar = false;
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            confirmationTextBox.UseSystemPasswordChar = true;
        }
    }

    public static class HashPasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                return hash;
            }
        }
    }
}
