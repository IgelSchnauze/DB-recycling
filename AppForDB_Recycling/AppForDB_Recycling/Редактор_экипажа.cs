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
    public partial class Редактор_экипажа : Form
    {
        public Редактор_экипажа(string carnum, string inn)
        {
            InitializeComponent();
            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            if (carnum == "") // если новый экипаж добавлять
            {
                OleDbCommand com_trans = new OleDbCommand("select Name from TransCompany", con);
                OleDbDataReader cursor_trans = com_trans.ExecuteReader();
                while (cursor_trans.Read())
                    comboBox_transp.Items.Add(cursor_trans[0]);

                cursor_trans.Close();
                con.Close();

                label_carnum.Tag = -1;
                return;
            }

            //если редачим сущ экипаж
            label_carnum.Text = label_carnum.Text + ": " + carnum;
            label_carnum.Tag = carnum;
            textBox_carnum.Visible = false;
            label_carnum_title.Visible = false;

            label_driver_inn.Text = label_driver_inn.Text + ", ИНН: " + inn;
            label_driver_inn.Tag = inn;
            textBox_inn.Visible = false;
            label_driver_inn_title.Visible = false;

            //заполнение исходными данными сначала
            OleDbCommand com_crew = new OleDbCommand("select Capacity, TransCompany, innDriver, Passport, PhoneNum from Crew " +
                                                     "inner join Driver D on D.innDriver = Crew.Driver " +
                                                     "where CarNumber = ?", con);
            com_crew.Parameters.AddWithValue("@carnum", carnum);

            OleDbDataReader cursor_crew = com_crew.ExecuteReader();
            while (cursor_crew.Read())
            {                
                textBox_capacity.Text = cursor_crew["Capacity"].ToString();
                comboBox_transp.Tag = cursor_crew["TransCompany"];  //id пока
                textBox_passport.Text = cursor_crew["Passport"].ToString();
                //приведение моб номера к нормальному виду без -
                textBox_mobile.Text = cursor_crew["PhoneNum"].ToString().Replace("-", string.Empty);
            }
            cursor_crew.Close();

            //заполнение трансп компаний
            OleDbCommand com_transp = new OleDbCommand("select idCompany, Name from TransCompany", con);
            OleDbDataReader cursor_transp = com_transp.ExecuteReader();
            while (cursor_transp.Read())
            {
                comboBox_transp.Items.Add(cursor_transp[1]);
                if (cursor_transp[0].ToString() == comboBox_transp.Tag.ToString())
                    comboBox_transp.Text = cursor_transp[1].ToString(); //назв-е исх компании
            }
            cursor_transp.Close();
            con.Close();
        }


        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // внесение изменений в бд
        private void but_done_Click(object sender, EventArgs e)
        {
            // проверка на корректность данных
            if (comboBox_transp.Text == "" || textBox_mobile.Text == "")
            {
                MessageBox.Show("Необходимо указать все параметры записи, помеченные звездочкой");
                return;
            }                        
            if (textBox_mobile.Text.Length != 11)
            {
                MessageBox.Show("Неправильно указан мобильный номер водителя");
                return;
            }

            //поиск id транпс. компании
            long id_trans = 0;
            string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
            OleDbConnection con = new OleDbConnection(forconnect);
            con.Open();

            OleDbCommand com_trans = new OleDbCommand("select idCompany, Name from TransCompany", con);
            OleDbDataReader cursor_trans = com_trans.ExecuteReader();
            while (cursor_trans.Read())
                if (cursor_trans["Name"].ToString() == comboBox_transp.Text)
                    id_trans = (long)cursor_trans["idCompany"];
            cursor_trans.Close();

            //преобразование моб номера         
            string mobile = string.Format("{0:#-###-###-##-##}", textBox_mobile.Text);            

            //проеобразование возможно пустых необязательных данных
            object passport = null;
            if (textBox_passport.Text != "")
                passport = textBox_passport.Text;
            object capacity = null;
            if (textBox_capacity.Text != "")
                capacity = textBox_capacity.Text;
                       
            if (label_carnum.Tag.ToString() == "-1") //если добавляем новую запись
            {
                // проверка на корректность данных
                if (textBox_inn.Text == "")
                {
                    MessageBox.Show("Необходимо указать все параметры записи, помеченные звездочкой");
                    return;
                }
                if (textBox_inn.Text.Length != 12)
                {
                    MessageBox.Show("Неправильно указан ИНН водителя");
                    return;
                }
                if (textBox_carnum.Text.Length != 6)
                {
                    MessageBox.Show("Неправильно указан номер машины");
                    con.Close();
                    return;
                }
                
                OleDbCommand com_add_driver = new OleDbCommand("insert into Driver (innDriver, Passport, PhoneNum) values (?, ?, ?)", con);
                com_add_driver.Parameters.AddWithValue("@inn", Convert.ToInt64(textBox_inn.Text));                
                com_add_driver.Parameters.AddWithValue("@passport", passport);
                com_add_driver.Parameters.AddWithValue("@phone", mobile);
                com_add_driver.ExecuteScalar();

                OleDbCommand com_add_crew = new OleDbCommand("insert into Crew (CarNumber, Capacity, Driver, TransCompany) values (?, ?, ?, ?)", con);
                com_add_crew.Parameters.AddWithValue("@carnum", textBox_carnum.Text);
                com_add_crew.Parameters.AddWithValue("@capac", capacity);
                com_add_crew.Parameters.AddWithValue("@driver", Convert.ToInt64(textBox_inn.Text));
                com_add_crew.Parameters.AddWithValue("@transp", id_trans);
                com_add_crew.ExecuteScalar();              
            }
            else //если редачим старую
            {
                OleDbCommand com_update_driver = new OleDbCommand("update Driver set Passport = ?, PhoneNum = ? " +
                                                                  "where innDriver = ?", con);
                com_update_driver.Parameters.AddWithValue("@passport", passport);
                com_update_driver.Parameters.AddWithValue("@phone", mobile);
                com_update_driver.Parameters.AddWithValue("@inn", Convert.ToInt64(label_driver_inn.Tag));
                com_update_driver.ExecuteScalar();

                OleDbCommand com_update_crew = new OleDbCommand("update Crew set Capacity = ?, TransCompany = ? " +
                                                                "where CarNumber = ?", con);
                com_update_crew.Parameters.AddWithValue("@capac", capacity);
                com_update_crew.Parameters.AddWithValue("@transp", id_trans);
                com_update_crew.Parameters.AddWithValue("@carnum", label_carnum.Tag.ToString());
                com_update_crew.ExecuteScalar();
            }
            
            con.Close();
            this.Close();
        }


        // ограничение на ввод некорректных символов в поля с числовыми данными
        private void textBox_capasity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //берем каждый введеный символ и пишем только те, которые будут цифрами или кл удаления
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8)
                e.Handled = true;            
        }

        private void textBox_inn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8)
                e.Handled = true;
        }

        private void textBox_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8)
                e.Handled = true;
        }
    }
}
