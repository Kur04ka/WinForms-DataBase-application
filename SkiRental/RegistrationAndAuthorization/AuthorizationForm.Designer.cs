namespace SkiRental
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegistrationTextBox = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.hidePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(141, 119);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(206, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(141, 72);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(206, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(80, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // RegistrationTextBox
            // 
            this.RegistrationTextBox.Location = new System.Drawing.Point(141, 197);
            this.RegistrationTextBox.Name = "RegistrationTextBox";
            this.RegistrationTextBox.Size = new System.Drawing.Size(206, 24);
            this.RegistrationTextBox.TabIndex = 4;
            this.RegistrationTextBox.Text = "Регистрация";
            this.RegistrationTextBox.UseVisualStyleBackColor = true;
            this.RegistrationTextBox.Click += new System.EventHandler(this.RegistrationTextBox_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(141, 168);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(206, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Войти";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // hidePassword
            // 
            this.hidePassword.AutoSize = true;
            this.hidePassword.Checked = true;
            this.hidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hidePassword.Location = new System.Drawing.Point(244, 145);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(103, 17);
            this.hidePassword.TabIndex = 6;
            this.hidePassword.Text = "Скрыть пароль";
            this.hidePassword.UseVisualStyleBackColor = true;
            this.hidePassword.CheckedChanged += new System.EventHandler(this.hidePassword_CheckedChanged);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 256);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.login);
            this.Controls.Add(this.RegistrationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegistrationTextBox;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.CheckBox hidePassword;
    }
}

