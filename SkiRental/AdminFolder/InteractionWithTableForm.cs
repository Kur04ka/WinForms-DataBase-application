using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void deleteTableButton_Click(object sender, EventArgs e)
        {
            DBConnection.Open();
            OleDbCommand command = new OleDbCommand($"DROP TABLE {selectedTableComboBox.SelectedItem}", DBConnection);
            command.ExecuteNonQuery();
            DBConnection.Close();
            MessageBox.Show($"Таблица {selectedTableComboBox.SelectedItem} была успешно удалена!");
            selectedTableComboBox.Text = "";
            UpdateTableComboBox();
        }

        /// <summary>
        /// Создание таблицы, первичного ключа и создание связи с таблицей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTableButton_Click(object sender, EventArgs e)
        {
            string column1 = "";
            string column2 = "";
            string column3 = "";
            string column4 = "";
            string column5 = "";

            string column1Type = "";
            string column2Type = "";
            string column3Type = "";
            string column4Type = "";
            string column5Type = "";

            string primaryKey = "";

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

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (!string.IsNullOrEmpty(textBox2.Text))
                    {
                        if (!string.IsNullOrEmpty(textBox3.Text))
                        {
                            if (!string.IsNullOrEmpty(textBox4.Text))
                            {
                                if (!string.IsNullOrEmpty(textBox5.Text))
                                {
                                    column1 = textBox1.Text;
                                    column1Type += comboBox1.SelectedItem.ToString();
                                    column1Type += ", ";
                                    column2 = textBox2.Text;
                                    column2Type += comboBox2.SelectedItem.ToString();
                                    column2Type += ", ";
                                    column3 = textBox3.Text;
                                    column3Type += comboBox3.SelectedItem.ToString();
                                    column3Type += ", ";
                                    column4 = textBox4.Text;
                                    column4Type += comboBox4.SelectedItem.ToString();
                                    column4Type += ", ";
                                    column5 = textBox5.Text;
                                    column5Type += comboBox5.SelectedItem.ToString();
                                }
                                else
                                {
                                    column1 = textBox1.Text;
                                    column1Type += comboBox1.SelectedItem.ToString();
                                    column1Type += ", ";
                                    column2 = textBox2.Text;
                                    column2Type += comboBox2.SelectedItem.ToString();
                                    column2Type += ", ";
                                    column3 = textBox3.Text;
                                    column3Type += comboBox3.SelectedItem.ToString();
                                    column3Type += ", ";
                                    column4 = textBox4.Text;
                                    column4Type += comboBox4.SelectedItem.ToString();
                                }          
                            }
                            else
                            {
                                column1 = textBox1.Text;
                                column1Type += comboBox1.SelectedItem.ToString();
                                column1Type += ", ";
                                column2 = textBox2.Text;
                                column2Type += comboBox2.SelectedItem.ToString();
                                column2Type += ", ";
                                column3 = textBox3.Text;
                                column3Type += comboBox3.SelectedItem.ToString();
                            }
                        }
                        else
                        {
                            column1 = textBox1.Text;
                            column1Type += comboBox1.SelectedItem.ToString();
                            column1Type += ", ";
                            column2 = textBox2.Text;
                            column2Type += comboBox1.SelectedItem.ToString();
                        }
                    }
                    else
                    {
                        column1 = textBox1.Text;
                        column1Type += comboBox1.SelectedItem.ToString();
                    }
                }

                if (makeKeyCheckBox.Checked)
                {
                    primaryKey = $", PRIMARY KEY ({column1})";
                }

                DBConnection.Open();
                string query = $"CREATE TABLE {newTableNameTextBox.Text} ({column1} {column1Type} {column2} {column2Type} {column3} {column3Type} {column4} {column4Type} {column5} {column5Type} {primaryKey})";
                OleDbCommand command = new OleDbCommand(query, DBConnection);
                command.ExecuteNonQuery();

                if (interlinkedTableComboBox.SelectedItem != null)
                {
                    string tableName = interlinkedTableComboBox.SelectedItem.ToString();
                    string queryKey = $"ALTER TABLE [{tableName}] ADD [{column1}] {column1Type.TrimEnd(new char[] { ',', ' ' })}";
                    OleDbCommand commandKey = new OleDbCommand(queryKey, DBConnection);
                    commandKey.ExecuteNonQuery();
                    string sqlBindingForeignKey = $"ALTER TABLE [{interlinkedTableComboBox.SelectedItem}] ADD FOREIGN KEY ([{column1}]) REFERENCES [{newTableNameTextBox.Text}]({column1})";
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
