using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkiRental.UserFolder
{
    public partial class UserForm : Form
    {
        #region Connection string and dictionary
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        private OleDbConnection DBConnection;
        private string userName;
        Dictionary<string, string> priceKeyValuePairs = new Dictionary<string, string>()
            {
                {"От 0 до 300", "Between 0 AND 300"},
                {"От 300 до 500", "Between 300 AND 500"},
                {"От 500 до 800", "Between 500 AND 800"},
                {"От 800 до 1000", "Between 800 AND 1000"}
            };
        #endregion

        public UserForm(string userName)
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectionString);
            this.userName = userName;
        }


        #region Buttons

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (priceComboBox.SelectedItem == null && typeOfItemComboBox.SelectedItem != null)
            {
                ShowTable($"SELECT * FROM Items WHERE typeOfTheItem LIKE '{typeOfItemComboBox.SelectedItem}'");
                dataGridView1.Update();
            }
            else if (priceComboBox.SelectedItem != null && typeOfItemComboBox.SelectedItem == null)
            {
                ShowTable($"SELECT * FROM Items WHERE priceFor1Hour {priceKeyValuePairs[(string)priceComboBox.SelectedItem]}");
                dataGridView1.Update();
            }
            else if (priceComboBox.SelectedItem != null && typeOfItemComboBox.SelectedItem != null)
            {
                ShowTable($"SELECT * FROM Items WHERE typeOfTheItem LIKE '{typeOfItemComboBox.SelectedItem}' AND priceFor1Hour {priceKeyValuePairs[(string)priceComboBox.SelectedItem]}");
                dataGridView1.Update();
            }
            else
            {
                ShowTable("SELECT * FROM Items");
                dataGridView1.Update();
            }

        }

        private void makeOrder_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {
                this.Hide();
                OrderForm orderForm = new OrderForm(dataGridView1.CurrentCell.Value.ToString().Trim(), userName);
                orderForm.ShowDialog();
            }
        }

        #endregion


        #region Functions

        private void ShowTable(string query)
        {
            try
            {
                OleDbDataAdapter command = new OleDbDataAdapter(query, DBConnection);
                DataTable dataTable = new DataTable();
                command.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Введите верную команду в текстовое поле!");
            }
        }

        private void UpdateComboBoxes()
        {
            typeOfItemComboBox.Items.Clear();
            typeOfItemComboBox.Text = string.Empty;

            DBConnection.Open();
            OleDbCommand command = new OleDbCommand("SELECT typeOfTheItem FROM Items GROUP BY typeOfTheItem", DBConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                typeOfItemComboBox.Items.Add(reader.GetValue(0));
            }

            foreach (var item in priceKeyValuePairs)
            {
                priceComboBox.Items.Add(item.Key);
            }
        }
 

        #endregion


        private void UserForm_Load(object sender, EventArgs e)
        {
            ShowTable($"SELECT * FROM Items");
            dataGridView1.Update();
            UpdateComboBoxes();
        }

        private void вызодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.ShowDialog();
        }
    }
}
