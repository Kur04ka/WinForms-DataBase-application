namespace SkiRental.UserFolder
{
    partial class OrderForm
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
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentalPeriodTextBox = new System.Windows.Forms.TextBox();
            this.orderCancelationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Location = new System.Drawing.Point(519, 106);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(261, 35);
            this.makeOrderButton.TabIndex = 0;
            this.makeOrderButton.Text = "Оформить заказ";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 161);
            this.dataGridView1.TabIndex = 1;
            // 
            // rentalPeriodTextBox
            // 
            this.rentalPeriodTextBox.Location = new System.Drawing.Point(519, 80);
            this.rentalPeriodTextBox.Name = "rentalPeriodTextBox";
            this.rentalPeriodTextBox.Size = new System.Drawing.Size(261, 20);
            this.rentalPeriodTextBox.TabIndex = 2;
            // 
            // orderCancelationButton
            // 
            this.orderCancelationButton.Location = new System.Drawing.Point(519, 147);
            this.orderCancelationButton.Name = "orderCancelationButton";
            this.orderCancelationButton.Size = new System.Drawing.Size(261, 35);
            this.orderCancelationButton.TabIndex = 3;
            this.orderCancelationButton.Text = "Отменить оформление заказа";
            this.orderCancelationButton.UseVisualStyleBackColor = true;
            this.orderCancelationButton.Click += new System.EventHandler(this.orderCancelationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите количество часов аренды снаряжения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderCancelationButton);
            this.Controls.Add(this.rentalPeriodTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.makeOrderButton);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox rentalPeriodTextBox;
        private System.Windows.Forms.Button orderCancelationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}