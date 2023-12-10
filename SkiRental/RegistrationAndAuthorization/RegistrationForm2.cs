using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiRental.RegistrationAndAuthorization
{
    public partial class RegistrationForm2 : Form
    {
        #region Строка подключения
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        private OleDbConnection DBConnection;
        string login, password;
        #endregion

        public RegistrationForm2(string login, string password)
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectionString);
            this.login = login;
            this.password = password;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            DBConnection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand($"INSERT INTO Customers (fullName, phoneNumber, email, dateOfBirth) VALUES (@fullName, @phoneNumber, @email, @dateOfBirth)", DBConnection);
                command.Parameters.AddWithValue("fullName", fullNameTextBox.Text);
                command.Parameters.AddWithValue("phoneNumber", phoneNumberTextBox.Text);
                command.Parameters.AddWithValue("email", emailTextBox.Text);
                command.Parameters.AddWithValue("dateOfBirth", dateOfBirthTExtBox.Text);
                command.ExecuteNonQuery();
                command = new OleDbCommand($"INSERT INTO Users (login, [password], fullName) VALUES (@login, @password, @fullName)", DBConnection);
                command.Parameters.AddWithValue("login", login);
                command.Parameters.AddWithValue("password", HashPasswordHelper.HashPassword(password));
                command.Parameters.AddWithValue("fullName", fullNameTextBox.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Пользователь был успешно создан!");
                this.Hide();
                AuthorizationForm authorizationForm = new AuthorizationForm();
                authorizationForm.ShowDialog();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Введите корректную дату рождения, пример: 17.11.2004");
            }
            DBConnection.Close();
        }
    }
}
