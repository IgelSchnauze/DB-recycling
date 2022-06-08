namespace AppForDB_Recycling
{
    partial class Страница_водителя
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.but_Show_table = new System.Windows.Forms.Button();
            this.datagrid_Timetab = new System.Windows.Forms.DataGridView();
            this.date_extime = new System.Windows.Forms.DateTimePicker();
            this.comboBox_address = new System.Windows.Forms.ComboBox();
            this.text_extime_hour = new System.Windows.Forms.TextBox();
            this.text_extime_min = new System.Windows.Forms.TextBox();
            this.but_add_extime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_carnum = new System.Windows.Forms.Label();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Timetab)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Show_table
            // 
            this.but_Show_table.BackColor = System.Drawing.Color.CadetBlue;
            this.but_Show_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Show_table.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Show_table.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_Show_table.Location = new System.Drawing.Point(680, 70);
            this.but_Show_table.Name = "but_Show_table";
            this.but_Show_table.Size = new System.Drawing.Size(125, 42);
            this.but_Show_table.TabIndex = 3;
            this.but_Show_table.Text = "Посмотреть";
            this.but_Show_table.UseVisualStyleBackColor = false;
            this.but_Show_table.Click += new System.EventHandler(this.but_show_table_Click);
            // 
            // datagrid_Timetab
            // 
            this.datagrid_Timetab.AllowUserToAddRows = false;
            this.datagrid_Timetab.AllowUserToDeleteRows = false;
            this.datagrid_Timetab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Timetab.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Timetab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.datagrid_Timetab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Timetab.Location = new System.Drawing.Point(12, 131);
            this.datagrid_Timetab.MaximumSize = new System.Drawing.Size(793, 184);
            this.datagrid_Timetab.MinimumSize = new System.Drawing.Size(793, 184);
            this.datagrid_Timetab.Name = "datagrid_Timetab";
            this.datagrid_Timetab.ReadOnly = true;
            this.datagrid_Timetab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Timetab.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datagrid_Timetab.RowsDefaultCellStyle = dataGridViewCellStyle39;
            this.datagrid_Timetab.RowTemplate.Height = 24;
            this.datagrid_Timetab.Size = new System.Drawing.Size(793, 184);
            this.datagrid_Timetab.TabIndex = 6;
            // 
            // date_extime
            // 
            this.date_extime.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_extime.Location = new System.Drawing.Point(13, 437);
            this.date_extime.Name = "date_extime";
            this.date_extime.Size = new System.Drawing.Size(203, 27);
            this.date_extime.TabIndex = 8;
            this.date_extime.ValueChanged += new System.EventHandler(this.date_extime_ValueChanged);
            // 
            // comboBox_address
            // 
            this.comboBox_address.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_address.FormattingEnabled = true;
            this.comboBox_address.Location = new System.Drawing.Point(246, 436);
            this.comboBox_address.Name = "comboBox_address";
            this.comboBox_address.Size = new System.Drawing.Size(244, 28);
            this.comboBox_address.TabIndex = 9;
            // 
            // text_extime_hour
            // 
            this.text_extime_hour.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_extime_hour.Location = new System.Drawing.Point(512, 436);
            this.text_extime_hour.MaxLength = 2;
            this.text_extime_hour.Name = "text_extime_hour";
            this.text_extime_hour.Size = new System.Drawing.Size(50, 27);
            this.text_extime_hour.TabIndex = 10;
            this.text_extime_hour.Text = "00";
            this.text_extime_hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_extime_hour_KeyPress);
            // 
            // text_extime_min
            // 
            this.text_extime_min.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_extime_min.Location = new System.Drawing.Point(593, 436);
            this.text_extime_min.MaxLength = 2;
            this.text_extime_min.Name = "text_extime_min";
            this.text_extime_min.Size = new System.Drawing.Size(57, 27);
            this.text_extime_min.TabIndex = 11;
            this.text_extime_min.Text = "00";
            this.text_extime_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_extime_min_KeyPress);
            // 
            // but_add_extime
            // 
            this.but_add_extime.BackColor = System.Drawing.Color.CadetBlue;
            this.but_add_extime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add_extime.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_add_extime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_add_extime.Location = new System.Drawing.Point(680, 425);
            this.but_add_extime.Name = "but_add_extime";
            this.but_add_extime.Size = new System.Drawing.Size(125, 45);
            this.but_add_extime.TabIndex = 12;
            this.but_add_extime.Text = "Изменить";
            this.but_add_extime.UseVisualStyleBackColor = false;
            this.but_add_extime.Click += new System.EventHandler(this.but_add_extime_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(570, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Заполнить время вывоза мусора или изменить существующее:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(568, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = ":";
            // 
            // label_carnum
            // 
            this.label_carnum.AutoSize = true;
            this.label_carnum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_carnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_carnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_carnum.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_carnum.Location = new System.Drawing.Point(12, 20);
            this.label_carnum.Name = "label_carnum";
            this.label_carnum.Size = new System.Drawing.Size(166, 25);
            this.label_carnum.TabIndex = 15;
            this.label_carnum.Text = "Номер машины: ";
            // 
            // date_from
            // 
            this.date_from.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_from.Location = new System.Drawing.Point(246, 83);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(196, 27);
            this.date_from.TabIndex = 1;
            // 
            // date_to
            // 
            this.date_to.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_to.Location = new System.Drawing.Point(478, 83);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(196, 27);
            this.date_to.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Посмотреть мое расписание с ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(448, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "до";
            // 
            // Страница_водителя
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(817, 496);
            this.Controls.Add(this.label_carnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_add_extime);
            this.Controls.Add(this.text_extime_min);
            this.Controls.Add(this.text_extime_hour);
            this.Controls.Add(this.comboBox_address);
            this.Controls.Add(this.date_extime);
            this.Controls.Add(this.datagrid_Timetab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Show_table);
            this.Controls.Add(this.date_to);
            this.Controls.Add(this.date_from);
            this.MaximumSize = new System.Drawing.Size(835, 543);
            this.MinimumSize = new System.Drawing.Size(835, 543);
            this.Name = "Страница_водителя";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_closed);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Timetab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_Show_table;
        private System.Windows.Forms.DataGridView datagrid_Timetab;
        private System.Windows.Forms.DateTimePicker date_extime;
        private System.Windows.Forms.ComboBox comboBox_address;
        private System.Windows.Forms.TextBox text_extime_hour;
        private System.Windows.Forms.TextBox text_extime_min;
        private System.Windows.Forms.Button but_add_extime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_carnum;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}