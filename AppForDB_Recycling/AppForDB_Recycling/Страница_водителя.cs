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
    public partial class Страница_водителя : Form
    {
        /*для пользователя (водителя): 
            - посмотреть свое расписание в определенный промежуток дней (табл Расписание)
            - заполнить время вывоза (табл Расписание)*/

        public Страница_водителя(string car, Form Login)
        {
            InitializeComponent();
            Login_form = Login;

            label_carnum.Text = label_carnum.Text + car;
            label_carnum.Tag = car;
        }

        // показ таблицы с расписанием на определенные даты
        private void but_show_table_Click(object sender, EventArgs e) 
        {
            datagrid_Timetab.Rows.Clear(); //старое удаляю

            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            OleDbCommand com_timetable = new OleDbCommand("select Date,AP.Address,R2.Address,ExportTime from Timetable " +
                                                           "inner join AssemPoint AP on Timetable.AssemPoint = AP.idPoint " +
                                                           "inner join Repository R2 on Timetable.Repository = R2.idRepos " +
                                                           "where Crew = ? and Date >= ? and Date <= ?", con);
            com_timetable.Parameters.AddWithValue("@car", label_carnum.Tag.ToString());
            DateTime from = new DateTime(date_from.Value.Year, date_from.Value.Month, date_from.Value.Day, 0, 0, 0);
            DateTime to = new DateTime(date_to.Value.Year, date_to.Value.Month, date_to.Value.Day, 0, 0, 0);
            com_timetable.Parameters.AddWithValue("@date_from", from);
            com_timetable.Parameters.AddWithValue("@date_to", to);

            //создаю таблицу без привязки данных
            datagrid_Timetab.ColumnCount = 4;
            datagrid_Timetab.Columns[0].Name = "Дата";
            datagrid_Timetab.Columns[1].Name = "Адрес пункта вывоза";
            datagrid_Timetab.Columns[2].Name = "Адрес хранилища";
            datagrid_Timetab.Columns[3].Name = "Время вывоза";
           
            OleDbDataReader cursor_tt = com_timetable.ExecuteReader();
            while (cursor_tt.Read())            
                datagrid_Timetab.Rows.Add(cursor_tt[0].ToString().Substring(0, 8), cursor_tt[1], cursor_tt[2], cursor_tt[3]);
            
            cursor_tt.Close();
            con.Close();            
        }

        /*OleDbDataAdapter adapt = new OleDbDataAdapter("select * from Timetable", con); //связь с виртуальной базой данных
            DataSet ds = new DataSet();
            adapt.Fill(ds, "TimeTable");
            con.Close();
            //datagrid_Timetab.DataSource = ds.Tables["TimeTable"]; //размещение в макете таблицы данных

            BindingSource binding = new BindingSource();
            binding.DataSource = ds.Tables[0];  //TimeTable

            DateTime from = new DateTime(date_from.Value.Year, date_from.Value.Month, date_from.Value.Day, 0, 0, 0);
            DateTime to = new DateTime(date_to.Value.Year, date_to.Value.Month, date_to.Value.Day, 0, 0, 0);
            //binding.Filter = string.Format("Crew LIKE '%{0}%' AND Date >=%{1}% AND Date <= %{2}%", Text, from, to);
            binding.Filter = string.Format("Crew LIKE '%{0}%'", Text);

            datagrid_Timetab.AutoGenerateColumns = false;
            datagrid_Timetab.DataSource = binding;

            //создание столбцов вручную
            DataGridViewTextBoxColumn C_Date = new DataGridViewTextBoxColumn();
            C_Date.DataPropertyName = "Date";
            C_Date.HeaderText = "Дата";
            datagrid_Timetab.Columns.Add(C_Date);

            DataGridViewTextBoxColumn C_Aspoint = new DataGridViewTextBoxColumn();
            C_Aspoint.DataPropertyName = "AssemPoint";
            C_Aspoint.HeaderText = "Адрес пункта вывоза";
            datagrid_Timetab.Columns.Add(C_Aspoint);

            DataGridViewTextBoxColumn C_Repos = new DataGridViewTextBoxColumn();
            C_Repos.DataPropertyName = "Repository";
            C_Repos.HeaderText = "Адрес хранилища";
            datagrid_Timetab.Columns.Add(C_Repos);

            DataGridViewTextBoxColumn C_Extime = new DataGridViewTextBoxColumn();
            C_Extime.DataPropertyName = "ExportTime";
            C_Extime.HeaderText = "Время вывоза";
            datagrid_Timetab.Columns.Add(C_Extime);*/

        Dictionary<object, object> id_addr = new Dictionary<object, object>();  //будет хранить адреса и их id

        // добавление в конкретную запись бд время вывоза 
        private void but_add_extime_Click(object sender, EventArgs e)
        {            
            if (comboBox_address.Text == "")
            {
                MessageBox.Show("Выберите адрес");
                return;
            }
            if (text_extime_hour.Text == "" || text_extime_min.Text == "")
            {
                MessageBox.Show("Введите время вывоза");
                return;
            }

            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            //обработка значений, по которым будут изменения в таблице
            DateTime date = new DateTime(date_extime.Value.Year, date_extime.Value.Month, date_extime.Value.Day, 0, 0, 0);
            int point = Convert.ToInt32(id_addr[comboBox_address.Text]);
            if (text_extime_hour.Text.Length == 1)
                text_extime_hour.Text = "0" + text_extime_hour.Text;
            string extime = text_extime_hour.Text + ":" + text_extime_min.Text + ":00.0000000";

            OleDbCommand com_update = new OleDbCommand("update Timetable set ExportTime = ? " +
                                                       "where Date = ? and AssemPoint = ? and Crew = ?", con);
            com_update.Parameters.AddWithValue("@extime", extime);
            com_update.Parameters.AddWithValue("@date", date.ToString());
            com_update.Parameters.AddWithValue("@point", point);
            com_update.Parameters.AddWithValue("@crew", label_carnum.Tag.ToString());

            com_update.ExecuteScalar();           
            con.Close();

            //удаление всех заполненных полей
            comboBox_address.Items.Clear();
            text_extime_hour.Text = "00";
            text_extime_min.Text = "00";
        }


        // заполнение доступных адресов в выбранную дату
        private void date_extime_ValueChanged(object sender, EventArgs e)
        {
            //очистить предыдущие адреса
            comboBox_address.Items.Clear();
            id_addr.Clear();

            if (date_extime.Value > DateTime.Now)
            {
                MessageBox.Show("Нельзя редактировать записи на будущие даты");
                return;
            }

            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();                        

            OleDbCommand com_check_date = new OleDbCommand("select AssemPoint, Address from Timetable " +
                                                           "inner join AssemPoint AP on AP.idPoint = Timetable.AssemPoint " +
                                                           "where Crew = ? and Date = ?", con);
            com_check_date.Parameters.AddWithValue("@car", label_carnum.Tag.ToString());
            string str_date_ex = date_extime.Value.Year.ToString() + '-' + date_extime.Value.Month.ToString() + '-' + date_extime.Value.Day.ToString();
            com_check_date.Parameters.AddWithValue("@date", str_date_ex);

            OleDbDataReader cursor_addr = com_check_date.ExecuteReader(); //здесь адреса пунктов в ту дату (если есть)
            
            while (cursor_addr.Read())            
                id_addr.Add(cursor_addr[1], cursor_addr[0]);      //key = "address", value = his id      

            if (id_addr.Count == 0)
            {
                MessageBox.Show("Этот день отсутсвует в вашем расписании");
                con.Close();
                return;
            }
            //заполняем адресами той даты список, чтобы водитель выбрал 1 из них                 
            foreach (object item in id_addr.Keys)
                 comboBox_address.Items.Add(item);

            con.Close();
        }


        private Form Login_form = new Form(); // главная форма
        private void Form_closed(object sender, FormClosedEventArgs e)
        {
            // возвращение главной формы
            Login_form.Show();
        }


        // ограничение на ввод некорректных символов в поля с числовыми данными
        private void text_extime_hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            //берем каждый введеный символ и пишем только те, которые будут цифрами или кл удаления
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8)
                e.Handled = true;
        }

        private void text_extime_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8)
                e.Handled = true;
        }
    }
}
