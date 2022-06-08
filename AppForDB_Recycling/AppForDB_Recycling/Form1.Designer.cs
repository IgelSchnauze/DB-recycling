namespace AppForDB_Recycling
{
    partial class Вход_в_систему
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
            this.rbut_I_am_admin = new System.Windows.Forms.RadioButton();
            this.rbut_I_am_driver = new System.Windows.Forms.RadioButton();
            this.text_Login = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.but_Try_login = new System.Windows.Forms.Button();
            this.label_log = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbut_I_am_admin
            // 
            this.rbut_I_am_admin.AutoSize = true;
            this.rbut_I_am_admin.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbut_I_am_admin.Location = new System.Drawing.Point(23, 29);
            this.rbut_I_am_admin.Name = "rbut_I_am_admin";
            this.rbut_I_am_admin.Size = new System.Drawing.Size(165, 24);
            this.rbut_I_am_admin.TabIndex = 0;
            this.rbut_I_am_admin.TabStop = true;
            this.rbut_I_am_admin.Text = "Я администратор";
            this.rbut_I_am_admin.UseVisualStyleBackColor = true;
            this.rbut_I_am_admin.CheckedChanged += new System.EventHandler(this.rbut_I_am_admin_CheckedChanged);
            // 
            // rbut_I_am_driver
            // 
            this.rbut_I_am_driver.AutoSize = true;
            this.rbut_I_am_driver.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbut_I_am_driver.Location = new System.Drawing.Point(221, 29);
            this.rbut_I_am_driver.Name = "rbut_I_am_driver";
            this.rbut_I_am_driver.Size = new System.Drawing.Size(120, 24);
            this.rbut_I_am_driver.TabIndex = 1;
            this.rbut_I_am_driver.TabStop = true;
            this.rbut_I_am_driver.Text = "Я водитель";
            this.rbut_I_am_driver.UseVisualStyleBackColor = true;
            this.rbut_I_am_driver.CheckedChanged += new System.EventHandler(this.rbut_I_am_driver_CheckedChanged);
            // 
            // text_Login
            // 
            this.text_Login.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Login.Location = new System.Drawing.Point(235, 140);
            this.text_Login.Name = "text_Login";
            this.text_Login.Size = new System.Drawing.Size(275, 27);
            this.text_Login.TabIndex = 2;
            this.text_Login.Tag = "";
            // 
            // text_Password
            // 
            this.text_Password.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Password.Location = new System.Drawing.Point(235, 189);
            this.text_Password.Name = "text_Password";
            this.text_Password.PasswordChar = '*';
            this.text_Password.Size = new System.Drawing.Size(275, 27);
            this.text_Password.TabIndex = 3;
            this.text_Password.UseSystemPasswordChar = true;
            // 
            // but_Try_login
            // 
            this.but_Try_login.BackColor = System.Drawing.Color.CadetBlue;
            this.but_Try_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Try_login.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Try_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Try_login.Location = new System.Drawing.Point(487, 236);
            this.but_Try_login.Name = "but_Try_login";
            this.but_Try_login.Size = new System.Drawing.Size(103, 29);
            this.but_Try_login.TabIndex = 4;
            this.but_Try_login.Text = "Войти";
            this.but_Try_login.UseVisualStyleBackColor = false;
            this.but_Try_login.Click += new System.EventHandler(this.but_Try_login_Click);
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_log.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_log.Location = new System.Drawing.Point(124, 0);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(54, 20);
            this.label_log.TabIndex = 5;
            this.label_log.Tag = "0";
            this.label_log.Text = "Логин";
            this.label_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_log);
            this.panel1.Location = new System.Drawing.Point(51, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 25);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(41, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 26);
            this.panel2.TabIndex = 8;
            // 
            // Вход_в_систему
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(660, 322);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.but_Try_login);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.text_Login);
            this.Controls.Add(this.rbut_I_am_driver);
            this.Controls.Add(this.rbut_I_am_admin);
            this.MaximumSize = new System.Drawing.Size(678, 369);
            this.MinimumSize = new System.Drawing.Size(678, 369);
            this.Name = "Вход_в_систему";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbut_I_am_admin;
        private System.Windows.Forms.RadioButton rbut_I_am_driver;
        private System.Windows.Forms.TextBox text_Login;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.Button but_Try_login;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

