using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SkiRental.AdminFolder
{
    public partial class CreateRecordForm : Form
    {
        #region Connection string
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        private OleDbConnection DBConnection;
        private string selectedTable;
        #endregion

        public CreateRecordForm()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectionString);
            UpdateSelectTableComboBox();
        }      


        #region Functions and Methods

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

        /// <summary>
        /// Функция, которая реагирует на смену таблицы в комбо-боксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = selectTableComboBox.SelectedItem.ToString();
            ShowTable($"SELECT * FROM {selectedTable}");
            dataGridView1.Update();
        }

        #endregion


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

        private void выборкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectRecordsForm adminForm = new SelectRecordsForm();
            adminForm.ShowDialog();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteRecordForm deleteRecordForm = new DeleteRecordForm();
            deleteRecordForm.ShowDialog();
        }

        private void редактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRecordForm editRecordForm = new EditRecordForm();
            editRecordForm.ShowDialog();
        }

        #endregion


        /// <summary>
        /// Кнопка, добавляющая запись в базу данных
        /// </summary>
        private void addRecordButton_Click(object sender, EventArgs e)
        {
            List<string> textBoxesStrings = new List<string>() { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            Dictionary<string, string> columnsMap = new Dictionary<string, string>();
            string columnsQueue, valuesQueue;
            columnsQueue = valuesQueue = "";

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (string.IsNullOrEmpty(textBoxesStrings[i]))
                {
                    continue;
                }
                else
                {
                    columnsMap.Add(dataGridView1.Columns[i].Name, textBoxesStrings[i]);
                }
            }
            
            foreach (var column in columnsMap)
            {
                columnsQueue += $"[{column.Key}], ";
                valuesQueue += $"'{column.Value}', ";
            }
            columnsQueue = columnsQueue.Substring(0, columnsQueue.Length - 2);
            valuesQueue = valuesQueue.Substring(0, valuesQueue.Length - 2);

            DBConnection.Open();
            string query = $"INSERT INTO {selectTableComboBox.Text} ({columnsQueue}) VALUES ({valuesQueue});";
            OleDbCommand command = new OleDbCommand(query, DBConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Запись была успешна добавлена!");
            DBConnection.Close();
            ShowTable($"SELECT * FROM {selectTableComboBox.Text}");

        }

    }
}
