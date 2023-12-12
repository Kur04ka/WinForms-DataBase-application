using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SkiRental.AdminFolder
{
    public partial class EditRecordForm : Form
    {
        #region Connection string
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        private OleDbConnection DBConnection;
        private string selectedTable;       
        #endregion

        public EditRecordForm()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectionString);
            UpdateSelectTableComboBox();
        }


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

        private void созданиеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRecordForm addRecordForm = new CreateRecordForm();
            addRecordForm.ShowDialog();
        }

        private void удалеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteRecordForm deleteRecordForm = new DeleteRecordForm();
            deleteRecordForm.ShowDialog();
        }

        #endregion


        /// <summary>
        /// Кнопка, редактирующая запись в базе данных
        /// </summary>
        private void editRecordButton_Click(object sender, EventArgs e)
        {
            List<string> textBoxesStrings = new List<string>() { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            Dictionary<string, string> columnsMap = new Dictionary<string, string>();
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

            DBConnection.Open();
            string query = $"UPDATE {selectTableComboBox.Text} SET ";
            foreach (var column in columnsMap)
            {
                query += $"{column.Key} = '{column.Value}', ";
            }
            query = query.Substring(0, query.Length - 2);
            query += $"WHERE {dataGridView1.Columns[0].Name} = '{dataGridView1.CurrentCell.Value.ToString().Trim()}'";
            OleDbCommand command = new OleDbCommand(query, DBConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Запись была успешна обновлена!");
            DBConnection.Close();
            ShowTable($"SELECT * FROM {selectTableComboBox.Text}");
        }

        
    }
}
