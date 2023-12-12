using SkiRental.UserFolder;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SkiRental
{

    public partial class AuthorizationForm : Form
    {
        #region Строка подключения
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        OleDbConnection DBConnection;
        #endregion


        public AuthorizationForm()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectionString);
        }


        #region Buttons

        private void login_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "" && passwordTextBox.Text != "")
            {
                DBConnection.Open();
                OleDbCommand command = new OleDbCommand($"SELECT * FROM Users WHERE login=@login AND password=@password", DBConnection);
                command.Parameters.AddWithValue("login", loginTextBox.Text);
                command.Parameters.AddWithValue("password", HashPasswordHelper.HashPassword(passwordTextBox.Text));
                if(command.ExecuteScalar() == null)
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
                else
                {
                    int result = (int)command.ExecuteScalar();
                    OleDbDataReader reader = command.ExecuteReader();
                    if (result > 0)
                    {
                        this.Hide();
                        while (reader.Read())
                        {
                            bool isAdmin = (bool)reader.GetValue(4);
                            if (isAdmin)
                            {
                                SelectRecordsForm adminForm = new SelectRecordsForm();
                                adminForm.ShowDialog();
                            }
                            else if (!isAdmin)
                            {
                                MessageBox.Show($"Добрый день, {(string)reader.GetValue(3)}!");
                                UserForm userForm = new UserForm((string)reader.GetValue(3));
                                userForm.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                }
                DBConnection.Close();
            }
            else
            {
                MessageBox.Show("Одно или несколько полей незаполнены!");
            }
        }

        private void RegistrationTextBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm1 registrationForm = new RegistrationForm1();
            registrationForm.ShowDialog();
        }

        #endregion


        #region CheckBox And FormLoad

        private void hidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (hidePassword.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }

        #endregion


    }
}
