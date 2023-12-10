using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiRental.UserFolder
{
    public partial class OrderForm : Form
    {
        #region Connection string
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        private OleDbConnection DBConnection;
        private int priceFor1Hour;
        private string itemName, userName;
        #endregion

        public OrderForm(string itemName, string userName)
        {
            InitializeComponent();
            this.itemName = itemName;
            this.userName = userName;
            DBConnection = new OleDbConnection(connectionString);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter command = new OleDbDataAdapter($"SELECT * FROM Items WHERE itemName LIKE '{itemName}'", DBConnection);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        #region Buttons

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            DBConnection.Open();
            OleDbCommand command = new OleDbCommand($"SELECT priceFor1Hour FROM Items WHERE itemName LIKE '{itemName}'", DBConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                priceFor1Hour = (int)reader.GetValue(0);
            }

            command = new OleDbCommand($"INSERT INTO Orders (customerName, itemName, dateOfRent, rentalPeriod, orderAmount) " +
                $"VALUES (@fullName, @itemName, @date, @rentalPeriod, @orderAmount)", DBConnection);
            command.Parameters.AddWithValue("@fullName", userName);
            command.Parameters.AddWithValue("@itemName", itemName);
            command.Parameters.AddWithValue("@date", DateTime.Today.ToString("d"));
            command.Parameters.AddWithValue("@rentalPeriod", Convert.ToInt32(rentalPeriodTextBox.Text));
            command.Parameters.AddWithValue("@orderAmount", Convert.ToInt32(rentalPeriodTextBox.Text) * priceFor1Hour);
            command.ExecuteNonQuery();
            DBConnection.Close();

            MessageBox.Show($"Заказ был успешно создан! Сумма заказа составила {Convert.ToInt32(rentalPeriodTextBox.Text) * priceFor1Hour} рублей");
            this.Hide();
            UserForm userForm = new UserForm(userName);
            userForm.ShowDialog();
        }


        private void orderCancelationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(userName);
            userForm.ShowDialog();
        }

        #endregion

    }
}
