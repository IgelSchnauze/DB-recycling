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
    public partial class Редактор_расписания : Form
    {
        public Редактор_расписания(int id)
        {
            InitializeComponent();
            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            //заполнение списков с выбором
            OleDbCommand com_assem = new OleDbCommand("select Address from AssemPoint", con);
            OleDbCommand com_crew = new OleDbCommand("select CarNumber from Crew", con);
            OleDbCommand com_repos = new OleDbCommand("select Address from Repository", con);

            OleDbDataReader cursor_assem = com_assem.ExecuteReader();
            while (cursor_assem.Read())
                comboBox_assem.Items.Add(cursor_assem[0]);
            cursor_assem.Close();
            OleDbDataReader cursor_crew = com_crew.ExecuteReader();
            while (cursor_crew.Read())
                comboBox_crew.Items.Add(cursor_crew[0]);
            cursor_crew.Close();
            OleDbDataReader cursor_repos = com_repos.ExecuteReader();
            while (cursor_repos.Read())
                comboBox_repos.Items.Add(cursor_repos[0]);
            cursor_repos.Close();

            //если будем новое создавать, а не старое редачить
            if (id == -1)
            {
                this.Text = "Добавление_записи";
                but_done.Text = "Добавить";
                label_id.Visible = false;
                label_id.Tag = -1;
                con.Close();
                return;
            }
            
            label_id.Text = label_id.Text + id.ToString();
            label_id.Tag = id;

            //установка значений как в первоначальной записи
            OleDbCommand com_thisstr = new OleDbCommand("select idOperation, Date, AP.Address, Crew, R2.Address from Timetable " +
                                                           "inner join AssemPoint AP on Timetable.AssemPoint = AP.idPoint " +
                                                           "inner join Repository R2 on Timetable.Repository = R2.idRepos " +
                                                           "where idOperation = ?", con);
            com_thisstr.Parameters.AddWithValue("@id", id);

            OleDbDataReader cursor_str = com_thisstr.ExecuteReader();
            while (cursor_str.Read())
            {
                comboBox_assem.Text = cursor_str[2].ToString();
                comboBox_crew.Text = cursor_str["Crew"].ToString();
                comboBox_repos.Text = cursor_str[4].ToString();
                date_operation.Value = (DateTime)cursor_str["Date"];                
            }
            cursor_str.Close();
            con.Close();
        }


        private void but_cancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        // внесение изменений в базу данных
        private void but_done_Click(object sender, EventArgs e)
        {
            if (date_operation.Value < DateTime.Now)
            {
                MessageBox.Show("Нельзя добавить запись на старые даты");                
                return;
            }
            if (comboBox_assem.Text == "" || comboBox_crew.Text == "" || comboBox_repos.Text == "")
            {
                MessageBox.Show("Есть пустые данные, необходимо выбрать все параметры записи");
                return;
            }

            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            //поиск id адресов
            int id_assem = 0; int id_repos = 0;
            OleDbCommand com_assem = new OleDbCommand("select idPoint, Address from AssemPoint", con);
            OleDbCommand com_repos = new OleDbCommand("select idRepos, Address from Repository", con);

            OleDbDataReader cursor_assem = com_assem.ExecuteReader();
            while (cursor_assem.Read())
                if (comboBox_assem.Text == cursor_assem["Address"].ToString())
                    id_assem = (int)cursor_assem["idPoint"];
            cursor_assem.Close();

            OleDbDataReader cursor_repos = com_repos.ExecuteReader();
            while (cursor_repos.Read())
                if (comboBox_repos.Text == cursor_repos["Address"].ToString())
                    id_repos = (int)cursor_repos["idRepos"];
            cursor_repos.Close();

            if ((int)label_id.Tag == -1)  //если добавляем новую запись
            {
                OleDbCommand com_add = new OleDbCommand("insert into Timetable (Date, AssemPoint, Crew, Repository) values (?, ?, ?, ?)", con);
                                                       
                com_add.Parameters.AddWithValue("@date", date_operation.Value);
                com_add.Parameters.AddWithValue("@assem", id_assem);
                com_add.Parameters.AddWithValue("@crew", comboBox_crew.Text);
                com_add.Parameters.AddWithValue("@repos", id_repos);
                
                com_add.ExecuteScalar();
            }
            else  //если редачим старую запись
            {                
                OleDbCommand com_update = new OleDbCommand("update Timetable set Date = ?, AssemPoint = ?, Crew = ?, Repository = ? " +
                                                           "where idOperation = ?", con);
                com_update.Parameters.AddWithValue("@date", date_operation.Value);
                com_update.Parameters.AddWithValue("@assem", id_assem);
                com_update.Parameters.AddWithValue("@crew", comboBox_crew.Text);
                com_update.Parameters.AddWithValue("@repos", id_repos);
                com_update.Parameters.AddWithValue("@id", (int)label_id.Tag);

                com_update.ExecuteScalar();
            }
                   
            con.Close();
            this.Close();
        }
        

        private void comboBox_assem_change(object sender, EventArgs e)
        {
            //адрес и машина должны быть одной компании
            comboBox_crew.Items.Clear();

            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            long id_transcom = 0;
            bool is_transcom = true;
            OleDbCommand com_assem = new OleDbCommand("select Address, TransCompany from AssemPoint", con);
            OleDbDataReader cursor_assem = com_assem.ExecuteReader();
            while (cursor_assem.Read())
            {
                if (comboBox_assem.Text == cursor_assem["Address"].ToString())
                {                    
                    // если компания не указана
                    if (cursor_assem["TransCompany"].ToString() == "")
                    {
                        is_transcom = false;
                        break;
                    }                    
                    id_transcom = (long)cursor_assem["TransCompany"];
                }
            }
            cursor_assem.Close();

            // если компания не указана, тогда с данного адреса не увозят мусор
            if (!is_transcom)
            {
                MessageBox.Show("Сейчас нет экипажей, которые обслуживают данный пункт сбора");
                con.Close();
                return;
            }

            //добавим только те машины, которые принадлежат этой компании           
            bool right_choosed = false;

            OleDbCommand com_crew = new OleDbCommand("select CarNumber, TransCompany from Crew", con);
            OleDbDataReader cursor_crew = com_crew.ExecuteReader();
            while (cursor_crew.Read())
            {
                if ((long)cursor_crew["TransCompany"] == id_transcom)
                {
                    comboBox_crew.Items.Add(cursor_crew["CarNumber"]);
                    //соответ-т ли выделенный вариант одному из возможных
                    if (cursor_crew["CarNumber"].ToString() == comboBox_crew.Text)
                        right_choosed = true;
                }
            }
            cursor_crew.Close();
            con.Close();

            if (comboBox_crew.Text == "") // еще не выбирали машину
                return;
            if (!right_choosed) // если нет совпадений со выбранной машиной
            {
                //значит надо убрать текущий вариант
                comboBox_crew.Text = "";
                MessageBox.Show("Выбранный экипаж относится к другой транспортной компании, необходимо выбрать другой экипаж или изменить пункт сбора");
            }
        }


        private void date_operation_ValueChanged(object sender, EventArgs e)
        {
            // нельзя добавлять новую запись на старые даты
            if ((date_operation.Value < DateTime.Now) && ((int)label_id.Tag == -1))
            {
                MessageBox.Show("Нельзя добавить запись на старые даты");
                return;
            }
        }
    }
}
