namespace SkiRental
{
    partial class SelectRecordsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectTableComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСЗапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.маToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляИспользованияМаскиНеобходимоИспользоватьСимволToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betweenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синтаксисBETWEEN100AND10000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иИлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбираетсяИИлиПервыйПараметрИИлиВторойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxAnd = new System.Windows.Forms.CheckBox();
            this.checkBoxOR = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // selectTableComboBox
            // 
            this.selectTableComboBox.FormattingEnabled = true;
            this.selectTableComboBox.Location = new System.Drawing.Point(9, 46);
            this.selectTableComboBox.Name = "selectTableComboBox";
            this.selectTableComboBox.Size = new System.Drawing.Size(123, 21);
            this.selectTableComboBox.TabIndex = 1;
            this.selectTableComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTableComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Первый параметр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Второй параметр";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(356, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 8;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(483, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(291, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(26, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(526, 46);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(103, 69);
            this.selectButton.TabIndex = 12;
            this.selectButton.Text = "Сделать выборку";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Значение параметра 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Значение параметра 2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзСистемыToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(176, 26);
            // 
            // выходИзСистемыToolStripMenuItem
            // 
            this.выходИзСистемыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.выходИзСистемыToolStripMenuItem.Name = "выходИзСистемыToolStripMenuItem";
            this.выходИзСистемыToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.выходИзСистемыToolStripMenuItem.Text = "Выход из системы";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.работаСТаблицамиToolStripMenuItem,
            this.работаСЗапToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            this.работаСТаблицамиToolStripMenuItem.Click += new System.EventHandler(this.работаСТаблицамиToolStripMenuItem_Click);
            // 
            // работаСЗапToolStripMenuItem
            // 
            this.работаСЗапToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеЗаписиToolStripMenuItem,
            this.редактированиеЗаписиToolStripMenuItem,
            this.удалениеЗаписиToolStripMenuItem});
            this.работаСЗапToolStripMenuItem.Name = "работаСЗапToolStripMenuItem";
            this.работаСЗапToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.работаСЗапToolStripMenuItem.Text = "Работа с записями";
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
            // удалениеЗаписиToolStripMenuItem
            // 
            this.удалениеЗаписиToolStripMenuItem.Name = "удалениеЗаписиToolStripMenuItem";
            this.удалениеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.удалениеЗаписиToolStripMenuItem.Text = "Удаление записи";
            this.удалениеЗаписиToolStripMenuItem.Click += new System.EventHandler(this.удалениеЗаписиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маToolStripMenuItem,
            this.betweenToolStripMenuItem,
            this.иИлиToolStripMenuItem});
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            // 
            // маToolStripMenuItem
            // 
            this.маToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дляИспользованияМаскиНеобходимоИспользоватьСимволToolStripMenuItem});
            this.маToolStripMenuItem.Name = "маToolStripMenuItem";
            this.маToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.маToolStripMenuItem.Text = "Маска";
            // 
            // дляИспользованияМаскиНеобходимоИспользоватьСимволToolStripMenuItem
            // 
            this.дляИспользованияМаскиНеобходимоИспользоватьСимволToolStripMenuItem.Name = "дляИспользованияМаскиНеобходимоИспользоватьСимволToolStripMenuItem";
            this.дляИспользованияМаскиНеобходимоИспользоватьСимволToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.дляИспользованияМаскиНеобходимоИспользоватьСимволToolStripMenuItem.Text = "Синтаксис: [LIKE \'К%\'] ";
            // 
            // betweenToolStripMenuItem
            // 
            this.betweenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.синтаксисBETWEEN100AND10000ToolStripMenuItem});
            this.betweenToolStripMenuItem.Name = "betweenToolStripMenuItem";
            this.betweenToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.betweenToolStripMenuItem.Text = "Between";
            // 
            // синтаксисBETWEEN100AND10000ToolStripMenuItem
            // 
            this.синтаксисBETWEEN100AND10000ToolStripMenuItem.Name = "синтаксисBETWEEN100AND10000ToolStripMenuItem";
            this.синтаксисBETWEEN100AND10000ToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.синтаксисBETWEEN100AND10000ToolStripMenuItem.Text = "Синтаксис: [BETWEEN 100 AND 10000]";
            // 
            // иИлиToolStripMenuItem
            // 
            this.иИлиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбираетсяИИлиПервыйПараметрИИлиВторойToolStripMenuItem});
            this.иИлиToolStripMenuItem.Name = "иИлиToolStripMenuItem";
            this.иИлиToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.иИлиToolStripMenuItem.Text = "И / Или";
            // 
            // выбираетсяИИлиПервыйПараметрИИлиВторойToolStripMenuItem
            // 
            this.выбираетсяИИлиПервыйПараметрИИлиВторойToolStripMenuItem.Name = "выбираетсяИИлиПервыйПараметрИИлиВторойToolStripMenuItem";
            this.выбираетсяИИлиПервыйПараметрИИлиВторойToolStripMenuItem.Size = new System.Drawing.Size(369, 22);
            this.выбираетсяИИлиПервыйПараметрИИлиВторойToolStripMenuItem.Text = "Выбирается И/Или первый параметр, И/Или второй ";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // checkBoxAnd
            // 
            this.checkBoxAnd.AutoSize = true;
            this.checkBoxAnd.Location = new System.Drawing.Point(9, 79);
            this.checkBoxAnd.Name = "checkBoxAnd";
            this.checkBoxAnd.Size = new System.Drawing.Size(34, 17);
            this.checkBoxAnd.TabIndex = 18;
            this.checkBoxAnd.Text = "И";
            this.checkBoxAnd.UseVisualStyleBackColor = true;
            this.checkBoxAnd.CheckedChanged += new System.EventHandler(this.checkBoxAnd_CheckedChanged);
            // 
            // checkBoxOR
            // 
            this.checkBoxOR.AutoSize = true;
            this.checkBoxOR.Location = new System.Drawing.Point(9, 102);
            this.checkBoxOR.Name = "checkBoxOR";
            this.checkBoxOR.Size = new System.Drawing.Size(46, 17);
            this.checkBoxOR.TabIndex = 19;
            this.checkBoxOR.Text = "Или";
            this.checkBoxOR.UseVisualStyleBackColor = true;
            this.checkBoxOR.CheckedChanged += new System.EventHandler(this.checkBoxOR_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectTableComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxOR);
            this.groupBox1.Controls.Add(this.checkBoxAnd);
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 133);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выборка";
            // 
            // SelectRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectRecordsForm";
            this.Text = "Панель Администратора";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox selectTableComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem выходИзСистемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem маToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляИспользованияМаскиНеобходимоИспользоватьСимволToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBoxAnd;
        private System.Windows.Forms.CheckBox checkBoxOR;
        private System.Windows.Forms.ToolStripMenuItem betweenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синтаксисBETWEEN100AND10000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иИлиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбираетсяИИлиПервыйПараметрИИлиВторойToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСЗапToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеЗаписиToolStripMenuItem;
    }
}