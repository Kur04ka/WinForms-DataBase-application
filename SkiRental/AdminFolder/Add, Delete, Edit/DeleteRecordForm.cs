using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SkiRental.AdminFolder
{
    public partial class DeleteRecordForm : Form
    {
        #region Connection string
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        private OleDbConnection DBConnection;
        private string selectedTable;
        #endregion

        public DeleteRecordForm()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectionString);
            UpdateSelectTableComboBox();
        }


        #region MenuStrip

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm form = new AuthorizationForm();
            form.ShowDialog();
        }

        private void работаСТаблицамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InteractionWithTableForm interactionWithTableForm = new InteractionWithTableForm();
            interactionWithTableForm.ShowDialog();
        }

        private void созданиеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRecordForm addRecordForm = new CreateRecordForm();
            addRecordForm.ShowDialog();
        }

        private void выборкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SelectRecordsForm adminForm = new SelectRecordsForm();
            adminForm.ShowDialog();
        }

        private void редактированиеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRecordForm editRecordForm = new EditRecordForm();
            editRecordForm.ShowDialog();
        }

        #endregion


        #region Functions

        /// <summary>
        /// Функция, который принимает SQL-запрос и выводит таблицу в dataGridView
        /// </summary>
        /// <param name="query">SQL-запрос</param>
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

        /// <summary>
        /// Обновление комбобокса с ВЫБОРОМ РАБОЧЕЙ ТАБЛИЦЫ
        /// </summary>
        private void UpdateSelectTableComboBox()
        {
            selectTableComboBox.Sorted = true;
            DBConnection.Open();
            selectTableComboBox.Items.Clear();
            DataTable table = DBConnection.GetSchema("Tables", new string[] { null, null, null, "TABLE" }); //список всех таблиц
            foreach (DataRow row in table.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();
                selectTableComboBox.Items.Add(tableName);
            }
            DBConnection.Close();
        }

        private void selectTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = selectTableComboBox.SelectedItem.ToString();
            ShowTable($"SELECT * FROM {selectedTable}");
            dataGridView1.Update();
        }

        #endregion

        
        /// <summary>
        /// Кнопка, удаляющая запись из базы данных
        /// </summary>
        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {
                DBConnection.Open();
                string query = $"DELETE FROM {selectTableComboBox.Text} WHERE {dataGridView1.Columns[0].Name} LIKE '{dataGridView1.CurrentCell.Value.ToString().Trim()}'";
                OleDbCommand command = new OleDbCommand(query, DBConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись была успешна удалена!");
                DBConnection.Close();
                ShowTable($"SELECT * FROM {selectTableComboBox.Text}");
            }
        }

    }
}
