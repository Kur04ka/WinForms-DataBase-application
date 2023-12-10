namespace SkiRental.AdminFolder
{
    partial class DeleteRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectTableComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСЗаписямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteRecordButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectTableComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удаление записи";
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Location = new System.Drawing.Point(204, 29);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(169, 37);
            this.deleteRecordButton.TabIndex = 5;
            this.deleteRecordButton.Text = "Удалить выбранную запись";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            this.deleteRecordButton.Click += new System.EventHandler(this.deleteRecordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название таблицы";
            // 
            // selectTableComboBox
            // 
            this.selectTableComboBox.FormattingEnabled = true;
            this.selectTableComboBox.Location = new System.Drawing.Point(6, 45);
            this.selectTableComboBox.Name = "selectTableComboBox";
            this.selectTableComboBox.Size = new System.Drawing.Size(161, 21);
            this.selectTableComboBox.TabIndex = 2;
            this.selectTableComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTableComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборкаToolStripMenuItem,
            this.работаСТаблицамиToolStripMenuItem,
            this.работаСЗаписямиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборкаToolStripMenuItem
            // 
            this.выборкаToolStripMenuItem.Name = "выборкаToolStripMenuItem";
            this.выборкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.выборкаToolStripMenuItem.Text = "Выборка";
            this.выборкаToolStripMenuItem.Click += new System.EventHandler(this.выборкаToolStripMenuItem_Click_1);
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            this.работаСТаблицамиToolStripMenuItem.Click += new System.EventHandler(this.работаСТаблицамиToolStripMenuItem_Click);
            // 
            // работаСЗаписямиToolStripMenuItem
            // 
            this.работаСЗаписямиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеЗаписиToolStripMenuItem,
            this.редактированиеЗаписиToolStripMenuItem});
            this.работаСЗаписямиToolStripMenuItem.Name = "работаСЗаписямиToolStripMenuItem";
            this.работаСЗаписямиToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.работаСЗаписямиToolStripMenuItem.Text = "Работа с записями";
            // 
            // созданиеЗаписиToolStripMenuItem
            // 
            this.созданиеЗаписиToolStripMenuItem.Name = "созданиеЗаписиToolStripMenuItem";
            this.созданиеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.созданиеЗаписиToolStripMenuItem.Text = "Создание записи";
            this.созданиеЗаписиToolStripMenuItem.Click += new System.EventHandler(this.созданиеЗаписиToolStripMenuItem_Click);
            // 
            // редактированиеЗаписиToolStripMenuItem
            // 
            this.редактированиеЗаписиToolStripMenuItem.Name = "редактированиеЗаписиToolStripMenuItem";
            this.редактированиеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.редактированиеЗаписиToolStripMenuItem.Text = "Редактирование записи";
            this.редактированиеЗаписиToolStripMenuItem.Click += new System.EventHandler(this.редактированиеЗаписиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // DeleteRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeleteRecordForm";
            this.Text = "DeleteRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСЗаписямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборкаToolStripMenuItem;
        private System.Windows.Forms.ComboBox selectTableComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}