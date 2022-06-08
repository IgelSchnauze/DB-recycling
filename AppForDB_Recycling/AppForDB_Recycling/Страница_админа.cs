using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForDB_Recycling
{
    public partial class Страница_админа : Form
    {
        /*для админа:
          - добавить/изменить запись в расписании
          - добавить/изменить экипаж = водитель+машина*/

        public Страница_админа(Form Login)
        {
            InitializeComponent();
            Login_form = Login;

            // Tag = 0 (Расписание), Tag = 1 (Экипажи)
            this.Tag = 0;
            Update_Table_Time();            
        }

        // обновление таблицы "Расписание"
        private void Update_Table_Time()
        {
            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            OleDbCommand com_time = new OleDbCommand("select * from Timetable", con);
            datagrid_table.Rows.Clear();
            datagrid_table.ColumnCount = 6;
            datagrid_table.Columns[0].Name = "ID";
            datagrid_table.Columns[1].Name = "Дата";
            datagrid_table.Columns[2].Name = "Пункт сбора";
            datagrid_table.Columns[3].Name = "Экипаж";
            datagrid_table.Columns[4].Name = "Хранилище";
            datagrid_table.Columns[5].Name = "Время вывоза";

            OleDbDataReader cursor_time = com_time.ExecuteReader();
            while (cursor_time.Read())
                datagrid_table.Rows.Add(cursor_time[0], cursor_time[1].ToString().Substring(0, 8), cursor_time[2], 
                                        cursor_time[3], cursor_time[4], cursor_time[5].ToString());

            cursor_time.Close();
            con.Close();
        }

        // обновление таблицы "Экипажи"
        private void Update_Table_Crew()
        {
            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            OleDbCommand com_crew = new OleDbCommand("select CarNumber, Capacity, TransCompany, innDriver, Passport, PhoneNum from Crew " +
                                                     "inner join Driver D on D.innDriver = Crew.Driver", con);
            datagrid_table.Rows.Clear();
            datagrid_table.ColumnCount = 6;
            datagrid_table.Columns[0].Name = "Номер машины";
            datagrid_table.Columns[1].Name = "Объем";
            datagrid_table.Columns[2].Name = "Трансп. компания";
            datagrid_table.Columns[3].Name = "ИНН водителя";
            datagrid_table.Columns[4].Name = "Паспорт водителя";
            datagrid_table.Columns[5].Name = "Моб. телефон водителя";

            OleDbDataReader cursor_crew = com_crew.ExecuteReader();
            while (cursor_crew.Read())
                datagrid_table.Rows.Add(cursor_crew[0], cursor_crew[1], cursor_crew[2], cursor_crew[3], cursor_crew[4], cursor_crew[5]);

            cursor_crew.Close();
            con.Close();            
        }


        private void but_update_table_Click(object sender, EventArgs e)
        {
            if ((int)this.Tag == 0)
                Update_Table_Time();
            else
                Update_Table_Crew();
        }

        // переход на специальную форму обновления определенной записи
        private void but_update_str_Click(object sender, EventArgs e)
        {
            if ((int)this.Tag == 0)
            {
                int choosed_id = (int)datagrid_table.CurrentRow.Cells[0].Value;
                Редактор_расписания newform = new Редактор_расписания(choosed_id);
                newform.Show();
            }
            else
            {
                string carnumber = datagrid_table.CurrentRow.Cells[0].Value.ToString();
                string inn = datagrid_table.CurrentRow.Cells[3].Value.ToString();
                Редактор_экипажа newform = new Редактор_экипажа(carnumber, inn);
                newform.Show();
            }           
        }

        // переход на специальную форму добавления новой записи
        private void but_insert_str_Click(object sender, EventArgs e)
        {
            if ((int)this.Tag == 0)
            {                
                Редактор_расписания newform = new Редактор_расписания(-1);
                newform.Show();
            }
            else
            {                
                Редактор_экипажа newform = new Редактор_экипажа("","");
                newform.Show();
            }
        }


        // Переход из раздела "Расписания"  в "Экипажи" и наоборот
        private void but_change_crew_time_Click(object sender, EventArgs e)
        {
            // Tag = 0 (Расписание), Tag = 1 (Экипажи)
            if ((int)this.Tag == 0)
            {
                this.Tag = 1;
                this.Text = "Страница \"Экипажи\"";
                but_change_crew_time.Text = "Перейти к \"Расписание\"";
                but_insert_str.Text = "Добавить новый экипаж";
                Update_Table_Crew();
                return;
            }

            if ((int)this.Tag == 1)
            {
                this.Tag = 0;
                this.Text = "Страница \"Расписание\"";
                but_change_crew_time.Text = "Перейти к \"Экипажи\"";
                but_insert_str.Text = "Добавить новую запись";
                Update_Table_Time();
            }
            
        }


        private Form Login_form = new Form(); // главная форма
        private void Form_closed(object sender, FormClosedEventArgs e)
        {
            // возвращение главной формы
            Login_form.Show();
        }
    }
}
