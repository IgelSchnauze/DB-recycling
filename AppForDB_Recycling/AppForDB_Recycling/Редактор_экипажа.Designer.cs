namespace AppForDB_Recycling
{
    partial class Редактор_экипажа
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
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_driver_inn_title = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_capacity = new System.Windows.Forms.TextBox();
            this.textBox_inn = new System.Windows.Forms.TextBox();
            this.comboBox_transp = new System.Windows.Forms.ComboBox();
            this.textBox_passport = new System.Windows.Forms.TextBox();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.label_carnum = new System.Windows.Forms.Label();
            this.label_driver_inn = new System.Windows.Forms.Label();
            this.label_carnum_title = new System.Windows.Forms.Label();
            this.textBox_carnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.CadetBlue;
            this.but_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_cancel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_cancel.Location = new System.Drawing.Point(516, 272);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(130, 40);
            this.but_cancel.TabIndex = 0;
            this.but_cancel.Text = "Отмена";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_done
            // 
            this.but_done.BackColor = System.Drawing.Color.CadetBlue;
            this.but_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_done.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_done.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_done.Location = new System.Drawing.Point(652, 272);
            this.but_done.Name = "but_done";
            this.but_done.Size = new System.Drawing.Size(134, 38);
            this.but_done.TabIndex = 1;
            this.but_done.Text = "Применить";
            this.but_done.UseVisualStyleBackColor = false;
            this.but_done.Click += new System.EventHandler(this.but_done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(303, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объем";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(449, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Трансп. компания*";
            // 
            // label_driver_inn_title
            // 
            this.label_driver_inn_title.AutoSize = true;
            this.label_driver_inn_title.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_driver_inn_title.Location = new System.Drawing.Point(122, 154);
            this.label_driver_inn_title.Name = "label_driver_inn_title";
            this.label_driver_inn_title.Size = new System.Drawing.Size(50, 22);
            this.label_driver_inn_title.TabIndex = 6;
            this.label_driver_inn_title.Text = "ИНН*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(303, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Паспортные данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(649, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Моб. телефон*";
            // 
            // textBox_capacity
            // 
            this.textBox_capacity.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_capacity.Location = new System.Drawing.Point(306, 74);
            this.textBox_capacity.MaxLength = 7;
            this.textBox_capacity.Name = "textBox_capacity";
            this.textBox_capacity.Size = new System.Drawing.Size(97, 25);
            this.textBox_capacity.TabIndex = 9;
            this.textBox_capacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_capasity_KeyPress);
            // 
            // textBox_inn
            // 
            this.textBox_inn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_inn.Location = new System.Drawing.Point(125, 190);
            this.textBox_inn.MaxLength = 12;
            this.textBox_inn.Name = "textBox_inn";
            this.textBox_inn.Size = new System.Drawing.Size(153, 25);
            this.textBox_inn.TabIndex = 10;
            this.textBox_inn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_inn_KeyPress);
            // 
            // comboBox_transp
            // 
            this.comboBox_transp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_transp.FormattingEnabled = true;
            this.comboBox_transp.Location = new System.Drawing.Point(452, 74);
            this.comboBox_transp.Name = "comboBox_transp";
            this.comboBox_transp.Size = new System.Drawing.Size(243, 26);
            this.comboBox_transp.TabIndex = 11;
            // 
            // textBox_passport
            // 
            this.textBox_passport.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport.Location = new System.Drawing.Point(306, 190);
            this.textBox_passport.Name = "textBox_passport";
            this.textBox_passport.Size = new System.Drawing.Size(311, 25);
            this.textBox_passport.TabIndex = 12;
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mobile.Location = new System.Drawing.Point(652, 190);
            this.textBox_mobile.MaxLength = 11;
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(126, 25);
            this.textBox_mobile.TabIndex = 13;
            this.textBox_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_mobile_KeyPress);
            // 
            // label_carnum
            // 
            this.label_carnum.AutoSize = true;
            this.label_carnum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_carnum.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_carnum.Location = new System.Drawing.Point(12, 74);
            this.label_carnum.Name = "label_carnum";
            this.label_carnum.Size = new System.Drawing.Size(70, 22);
            this.label_carnum.TabIndex = 14;
            this.label_carnum.Text = "Машина";
            // 
            // label_driver_inn
            // 
            this.label_driver_inn.AutoSize = true;
            this.label_driver_inn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_driver_inn.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_driver_inn.Location = new System.Drawing.Point(12, 193);
            this.label_driver_inn.Name = "label_driver_inn";
            this.label_driver_inn.Size = new System.Drawing.Size(90, 22);
            this.label_driver_inn.TabIndex = 15;
            this.label_driver_inn.Text = "Водитель";
            // 
            // label_carnum_title
            // 
            this.label_carnum_title.AutoSize = true;
            this.label_carnum_title.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_carnum_title.Location = new System.Drawing.Point(122, 37);
            this.label_carnum_title.Name = "label_carnum_title";
            this.label_carnum_title.Size = new System.Drawing.Size(70, 22);
            this.label_carnum_title.TabIndex = 16;
            this.label_carnum_title.Text = "Номер*";
            // 
            // textBox_carnum
            // 
            this.textBox_carnum.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_carnum.Location = new System.Drawing.Point(125, 74);
            this.textBox_carnum.MaxLength = 6;
            this.textBox_carnum.Name = "textBox_carnum";
            this.textBox_carnum.Size = new System.Drawing.Size(102, 25);
            this.textBox_carnum.TabIndex = 17;
            // 
            // Редактор_экипажа
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(799, 325);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_carnum);
            this.Controls.Add(this.label_carnum_title);
            this.Controls.Add(this.label_driver_inn);
            this.Controls.Add(this.label_carnum);
            this.Controls.Add(this.textBox_mobile);
            this.Controls.Add(this.textBox_passport);
            this.Controls.Add(this.comboBox_transp);
            this.Controls.Add(this.textBox_inn);
            this.Controls.Add(this.textBox_capacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_driver_inn_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_done);
            this.Controls.Add(this.but_cancel);
            this.Name = "Редактор_экипажа";
            this.ShowIcon = false;
            this.Text = "Редактор экипажа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_driver_inn_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_capacity;
        private System.Windows.Forms.TextBox textBox_inn;
        private System.Windows.Forms.ComboBox comboBox_transp;
        private System.Windows.Forms.TextBox textBox_passport;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.Label label_carnum;
        private System.Windows.Forms.Label label_driver_inn;
        private System.Windows.Forms.Label label_carnum_title;
        private System.Windows.Forms.TextBox textBox_carnum;
    }
}