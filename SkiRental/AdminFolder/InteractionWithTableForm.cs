using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SkiRental.AdminFolder
{
    public partial class InteractionWithTableForm : Form
    {
        #region Connection string
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=skiRental.mdb";
        private OleDbConnection DBConnection;
        #endregion

        public InteractionWithTableForm()
        {
            InitializeComponent();
            DBConnection = new OleDbConnection(connectionString);
            UpdateTableComboBox();
            textBoxInitialize();
        }


        #region Functions

        private void UpdateTableComboBox()
        {
            selectedTableComboBox.Sorted = true;
            DBConnection.Open();
            selectedTableComboBox.Items.Clear();
            DataTable table = DBConnection.GetSchema("Tables", new string[] { null, null, null, "TABLE" }); //список всех таблиц
            foreach (DataRow row in table.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();
                selectedTableComboBox.Items.Add(tableName);
                interlinkedTableComboBox.Items.Add(tableName);
            }
            DBConnection.Close();
        }

        private void UpdateTextBoxesAndComboBoxes()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";

            textBox1.Text = comboBox1.Text;
            textBox2.Text = comboBox2.Text;
            textBox3.Text = comboBox3.Text;
            textBox4.Text = comboBox4.Text;
            comboBox5.Text = comboBox5.Text;

            selectedTableComboBox.Text = "";
            newTableNameTextBox.Text = "";
        }

        #endregion


        #region Buttons

        /// <summary>
        /// Удаление таблицы базы данных, внешнего ключа и связи
        /// </summary>
        private void deleteTableButton_Click(object sender, EventArgs e)
        {
            DBConnection.Open();
            string deletedTable = selectedTableComboBox.SelectedItem.ToString();
            OleDbCommand command;
            selectedTableComboBox.Items.Remove(deletedTable);
            selectedTableComboBox.Items.Remove(deletedTable);
            DataTable foreignKeys = DBConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, new object[] { null, null, deletedTable });

            string sqlDeleteTableQuery = $"DROP TABLE [{deletedTable}]";
            string sqlDeleteRelationshipQuery = "";
            string sqlDeleteForeignKeysQuery = "";

            if (foreignKeys.Rows.Count > 0)
            {
                foreach (DataRow row in foreignKeys.Rows)
                {
                    string relationshipName = row["FK_NAME"].ToString();
                    string tableWithRelationship = row["FK_TABLE_NAME"].ToString();
                    sqlDeleteRelationshipQuery = $"ALTER TABLE [{tableWithRelationship}] DROP CONSTRAINT [{relationshipName}]";
                    command = new OleDbCommand(sqlDeleteRelationshipQuery, DBConnection);
                    command.ExecuteNonQuery();
                }
                foreach (DataRow row in foreignKeys.Rows)
                {
                    string foreignKeyFieldName = row["FK_COLUMN_NAME"].ToString();
                    string tableWithRelationship = row["FK_TABLE_NAME"].ToString();
                    sqlDeleteForeignKeysQuery = $"ALTER TABLE [{tableWithRelationship}] DROP [{foreignKeyFieldName}]";
                    command = new OleDbCommand(sqlDeleteForeignKeysQuery, DBConnection);
                    command.ExecuteNonQuery();
                }
            }
            command = new OleDbCommand($"DROP TABLE {deletedTable}", DBConnection);
            command.ExecuteNonQuery();
            DBConnection.Close();
            MessageBox.Show($"Таблица {selectedTableComboBox.SelectedItem} была успешно удалена!");
            selectedTableComboBox.Text = "";
            UpdateTableComboBox();
        }

        /// <summary>
        /// Создание таблицы, первичного и внешнего ключей, создание связи с таблицей
        /// </summary>
        private void createTableButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && newTableNameTextBox.Text != string.Empty)
            {
                foreach (string name in selectedTableComboBox.Items)
                {
                    if (newTableNameTextBox.Text == name)
                    {
                        MessageBox.Show("Таблица с таким именем уже существует. Введите новое имя таблицы и попробуйте еще раз.");
                        return;
                    }
                }

                List<string> columnNameStrings = new List<string>() { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };
                List<string> dataTypeStrings = new List<string>() { comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text };
                string query = $"CREATE TABLE {newTableNameTextBox.Text} (";
                for (int i = 0; i < 5; i++)
                {
                    if (string.IsNullOrEmpty(columnNameStrings[i]))
                    {
                        continue;
                    }
                    else
                    {
                        query += $"{columnNameStrings[i]} {dataTypeStrings[i]}, ";
                    }
                }
                query += $"PRIMARY KEY ({textBox1.Text}))";

                DBConnection.Open();
                OleDbCommand command = new OleDbCommand(query, DBConnection);
                command.ExecuteNonQuery();
                if (interlinkedTableComboBox.SelectedItem != null)
                {
                    string tableName = interlinkedTableComboBox.SelectedItem.ToString();
                    string queryKey = $"ALTER TABLE [{tableName}] ADD [{textBox1.Text}] {comboBox1.Text.TrimEnd(new char[] { ',', ' ' })}";
                    OleDbCommand commandKey = new OleDbCommand(queryKey, DBConnection);
                    commandKey.ExecuteNonQuery();
                    string sqlBindingForeignKey = $"ALTER TABLE [{interlinkedTableComboBox.SelectedItem}] ADD FOREIGN KEY ([{textBox1.Text}]) REFERENCES [{newTableNameTextBox.Text}]({textBox1.Text})";
                    OleDbCommand commandBinding = new OleDbCommand(sqlBindingForeignKey, DBConnection);
                    commandBinding.ExecuteNonQuery();
                }
                DBConnection.Close();
                MessageBox.Show("Таблица была успешно создана!");
                UpdateTextBoxesAndComboBoxes();
                UpdateTableComboBox();
            }
            else
            {
                MessageBox.Show("Не все обязательные поля заполнены. Введите данные в пустые поля и попробуйте еще раз.");
                return;
            }
        }

        #endregion


        #region MenuStrip

        private void выборкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectRecordsForm adminForm = new SelectRecordsForm();
            adminForm.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm form = new AuthorizationForm();
            form.ShowDialog();
        }

        private void созданиеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRecordForm createRecordForm = new CreateRecordForm();
            createRecordForm.ShowDialog();
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


        #region Textboxes and comboxes 

        private void textBoxInitialize()
        {
            textBox5.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox2.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            comboBox2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            comboBox3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            comboBox4.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            comboBox5.Enabled = true;
        }


        #endregion


    }
}
