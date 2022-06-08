namespace AppForDB_Recycling
{
    partial class Редактор_расписания
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
            this.label_id = new System.Windows.Forms.Label();
            this.date_operation = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but_done = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.comboBox_assem = new System.Windows.Forms.ComboBox();
            this.comboBox_crew = new System.Windows.Forms.ComboBox();
            this.comboBox_repos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_id.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id.Location = new System.Drawing.Point(12, 18);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(130, 22);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID записи = ";
            // 
            // date_operation
            // 
            this.date_operation.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_operation.Location = new System.Drawing.Point(12, 122);
            this.date_operation.Name = "date_operation";
            this.date_operation.Size = new System.Drawing.Size(153, 25);
            this.date_operation.TabIndex = 1;
            this.date_operation.ValueChanged += new System.EventHandler(this.date_operation_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(185, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пункт сбора (откуда)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(447, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Экипаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(594, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Хранилище (куда)";
            // 
            // but_done
            // 
            this.but_done.BackColor = System.Drawing.Color.CadetBlue;
            this.but_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_done.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_done.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_done.Location = new System.Drawing.Point(686, 204);
            this.but_done.Name = "but_done";
            this.but_done.Size = new System.Drawing.Size(133, 42);
            this.but_done.TabIndex = 9;
            this.but_done.Text = "Применить";
            this.but_done.UseVisualStyleBackColor = false;
            this.but_done.Click += new System.EventHandler(this.but_done_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.CadetBlue;
            this.but_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_cancel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_cancel.Location = new System.Drawing.Point(548, 204);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(132, 41);
            this.but_cancel.TabIndex = 10;
            this.but_cancel.Text = "Отмена";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // comboBox_assem
            // 
            this.comboBox_assem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_assem.FormattingEnabled = true;
            this.comboBox_assem.Location = new System.Drawing.Point(189, 120);
            this.comboBox_assem.Name = "comboBox_assem";
            this.comboBox_assem.Size = new System.Drawing.Size(240, 26);
            this.comboBox_assem.TabIndex = 11;
            this.comboBox_assem.SelectedValueChanged += new System.EventHandler(this.comboBox_assem_change);
            // 
            // comboBox_crew
            // 
            this.comboBox_crew.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_crew.FormattingEnabled = true;
            this.comboBox_crew.Location = new System.Drawing.Point(451, 120);
            this.comboBox_crew.Name = "comboBox_crew";
            this.comboBox_crew.Size = new System.Drawing.Size(123, 26);
            this.comboBox_crew.TabIndex = 12;
            // 
            // comboBox_repos
            // 
            this.comboBox_repos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_repos.FormattingEnabled = true;
            this.comboBox_repos.Location = new System.Drawing.Point(598, 120);
            this.comboBox_repos.Name = "comboBox_repos";
            this.comboBox_repos.Size = new System.Drawing.Size(221, 26);
            this.comboBox_repos.TabIndex = 13;
            // 
            // Редактор_расписания
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(834, 262);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox_repos);
            this.Controls.Add(this.comboBox_crew);
            this.Controls.Add(this.comboBox_assem);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_done);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_operation);
            this.Controls.Add(this.label_id);
            this.Name = "Редактор_расписания";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор записи в расписании";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.DateTimePicker date_operation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_done;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.ComboBox comboBox_assem;
        private System.Windows.Forms.ComboBox comboBox_crew;
        private System.Windows.Forms.ComboBox comboBox_repos;
    }
}