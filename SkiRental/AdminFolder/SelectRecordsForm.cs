using SkiRental.AdminFolder;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace SkiRental
{
    public partial class SelectRecordsForm : Form
    {
        #region Connection string
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        private OleDbConnection DBConnection;
        private string selectedTable;
        #endregion


        public SelectRecordsForm()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectionString);
            UpdateSelectTableComboBox();
        }


        #region ComboBox Region

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
        /// Обновление комбобоксов с ПАРАМЕТРАМИ СОРТИРОВКИ
        /// </summary>
        private void UpdateComboBoxes() 
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                comboBox1.Items.Add(dataGridView1.Columns[i].Name);
                comboBox2.Items.Add(dataGridView1.Columns[i].Name);
            }
        }
        
        /// <summary>
        /// Вывод данных в dataGridView из таблицы, указанной в комбобоксе
        /// </summary>
        private void selectTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = selectTableComboBox.SelectedItem.ToString();
            ShowTable($"SELECT * FROM {selectedTable}");
            dataGridView1.Update();
            UpdateComboBoxes();
        }

        #endregion


        #region Functions and SelectButton

        /// <summary>
        /// Метод, который принимает SQL-запрос и выводит таблицу в dataGridView
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
        /// Кнопка для выборки
        /// </summary>
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked) // Стоит галочка только в первом
            {
                ShowTable($"SELECT * FROM {selectedTable} WHERE {comboBox1.SelectedItem} {textBox1.Text}");
            }
            else if (checkBox2.Checked && !checkBox1.Checked) // Стоит галочка только во втором
            {
                ShowTable($"SELECT * FROM {selectedTable} WHERE {comboBox2.SelectedItem} {textBox2.Text}");
            }
            else if (checkBox1.Checked && checkBox2.Checked) // Стоят галочки и в первом, и во втором
            {
                if (checkBoxAnd.Checked) // Если И первый параметр, И второй
                {
                    ShowTable($"SELECT * FROM {selectedTable} WHERE {comboBox1.SelectedItem} {textBox1.Text} AND {comboBox2.SelectedItem} {textBox2.Text}");
                }
                else if (checkBoxOR.Checked) // Если ИЛИ первый параметр, ИЛИ второй
                {
                    ShowTable($"SELECT * FROM {selectedTable} WHERE {comboBox1.SelectedItem} {textBox1.Text} OR {comboBox2.SelectedItem} {textBox2.Text}");
                }
                else
                {
                    MessageBox.Show("Поставьте галочку напротив одной из надписей 'И' или 'ИЛИ'");
                }
            }
            else // Галочки не стоят нигде
            {
                MessageBox.Show("Выберите хотя бы один параметр!");
            }
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

        private void созданиеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRecordForm addRecordForm = new CreateRecordForm();
            addRecordForm.ShowDialog();
        }

        private void редактированиеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRecordForm editRecordForm = new EditRecordForm();
            editRecordForm.ShowDialog();
        }

        private void удалениеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteRecordForm deleteRecordForm = new DeleteRecordForm();
            deleteRecordForm.ShowDialog();
        }

        #endregion


        #region AND / OR

        int x;
        private void checkBoxAnd_CheckedChanged(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                checkBoxOR.Enabled = false;
            }
            else
            {
                checkBoxOR.Enabled = true;
            }
            x++;
        }

        private void checkBoxOR_CheckedChanged(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                checkBoxAnd.Enabled = false;
            }
            else
            {
                checkBoxAnd.Enabled = true;
            }
            x++;
        }






        #endregion


    }
}
