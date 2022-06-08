namespace AppForDB_Recycling
{
    partial class Страница_админа
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_table = new System.Windows.Forms.DataGridView();
            this.but_change_crew_time = new System.Windows.Forms.Button();
            this.but_update_str = new System.Windows.Forms.Button();
            this.but_insert_str = new System.Windows.Forms.Button();
            this.but_update_table = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_table)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_table
            // 
            this.datagrid_table.AllowUserToAddRows = false;
            this.datagrid_table.AllowUserToDeleteRows = false;
            this.datagrid_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_table.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_table.Location = new System.Drawing.Point(9, 12);
            this.datagrid_table.Name = "datagrid_table";
            this.datagrid_table.ReadOnly = true;
            this.datagrid_table.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datagrid_table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_table.RowTemplate.Height = 24;
            this.datagrid_table.Size = new System.Drawing.Size(905, 270);
            this.datagrid_table.TabIndex = 0;
            // 
            // but_change_crew_time
            // 
            this.but_change_crew_time.BackColor = System.Drawing.Color.GhostWhite;
            this.but_change_crew_time.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.but_change_crew_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_change_crew_time.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_change_crew_time.Location = new System.Drawing.Point(624, 424);
            this.but_change_crew_time.Name = "but_change_crew_time";
            this.but_change_crew_time.Size = new System.Drawing.Size(290, 37);
            this.but_change_crew_time.TabIndex = 1;
            this.but_change_crew_time.Text = "Перейти к \"Экипажи\"";
            this.but_change_crew_time.UseVisualStyleBackColor = false;
            this.but_change_crew_time.Click += new System.EventHandler(this.but_change_crew_time_Click);
            // 
            // but_update_str
            // 
            this.but_update_str.BackColor = System.Drawing.Color.CadetBlue;
            this.but_update_str.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_update_str.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_update_str.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_update_str.Location = new System.Drawing.Point(12, 306);
            this.but_update_str.Name = "but_update_str";
            this.but_update_str.Size = new System.Drawing.Size(310, 38);
            this.but_update_str.TabIndex = 2;
            this.but_update_str.Text = "Редактировать выделенную строку";
            this.but_update_str.UseVisualStyleBackColor = false;
            this.but_update_str.Click += new System.EventHandler(this.but_update_str_Click);
            // 
            // but_insert_str
            // 
            this.but_insert_str.BackColor = System.Drawing.Color.CadetBlue;
            this.but_insert_str.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_insert_str.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_insert_str.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_insert_str.Location = new System.Drawing.Point(12, 360);
            this.but_insert_str.Name = "but_insert_str";
            this.but_insert_str.Size = new System.Drawing.Size(310, 37);
            this.but_insert_str.TabIndex = 3;
            this.but_insert_str.Text = "Добавить новую запись";
            this.but_insert_str.UseVisualStyleBackColor = false;
            this.but_insert_str.Click += new System.EventHandler(this.but_insert_str_Click);
            // 
            // but_update_table
            // 
            this.but_update_table.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_update_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_update_table.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_update_table.Location = new System.Drawing.Point(769, 288);
            this.but_update_table.Name = "but_update_table";
            this.but_update_table.Size = new System.Drawing.Size(145, 30);
            this.but_update_table.TabIndex = 4;
            this.but_update_table.Text = "Обновить";
            this.but_update_table.UseVisualStyleBackColor = false;
            this.but_update_table.Click += new System.EventHandler(this.but_update_table_Click);
            // 
            // Страница_админа
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(920, 473);
            this.Controls.Add(this.but_update_table);
            this.Controls.Add(this.but_insert_str);
            this.Controls.Add(this.but_update_str);
            this.Controls.Add(this.but_change_crew_time);
            this.Controls.Add(this.datagrid_table);
            this.Name = "Страница_админа";
            this.ShowIcon = false;
            this.Text = "Страница \"Расписание\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_closed);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_table;
        private System.Windows.Forms.Button but_change_crew_time;
        private System.Windows.Forms.Button but_update_str;
        private System.Windows.Forms.Button but_insert_str;
        private System.Windows.Forms.Button but_update_table;
    }
}