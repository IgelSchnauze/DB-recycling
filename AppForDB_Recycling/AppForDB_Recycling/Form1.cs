using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;   // для связи с БД
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForDB_Recycling
{
    public partial class Вход_в_систему : Form
    {
        public Вход_в_систему()
        {
            InitializeComponent();           
        }

        //попытка авторизации
        private void but_Try_login_Click(object sender, EventArgs e)  
        {
            /*text_Login.Text = "80000003423";
            text_Password.Text = "helloitsme";*/
            text_Login.Text = "justadmin";
            text_Password.Text = "nothing";

            if (text_Login.Text == "" || text_Password.Text == "")
            {
                MessageBox.Show("Заполните поля \"Логин\" и \"Пароль\"");
                return;
            }
            
            string login = text_Login.Text;
            string password = text_Password.Text;

            // проверка логина-пароля администратора 
            if (rbut_I_am_admin.Checked)
            {
                string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
                OleDbConnection con = new OleDbConnection(forconnect);
                con.Open();

                OleDbCommand com_admin = new OleDbCommand("select _pass_word_ from Admin_Log where _login_ = ?", con);                
                com_admin.Parameters.AddWithValue("@log",login);
                login = "'1'; insert into Admin_Log(_login_, _pass_word_) values('1', '1')";

                OleDbDataReader cursor_admin = com_admin.ExecuteReader();
                string bd_password = "";
                while (cursor_admin.Read())
                    bd_password = cursor_admin[0].ToString();

                cursor_admin.Close();
                con.Close();

                if (password != bd_password)
                {
                    MessageBox.Show("Неверный логин или пароль");
                    return;
                }
                else
                {
                    Страница_админа newform = new Страница_админа(this);
                    this.Hide();
                    text_Login.Text = "";
                    text_Password.Text = "";
                    newform.Show();
                }                
            }

            // проверка логина-пароля водителя
            if (rbut_I_am_driver.Checked)
            {                
                long login_phone = Convert.ToInt64(login);
                if (login_phone >= 80000000000 && login_phone <= 89999999999)
                    login = string.Format("{0:#-###-###-##-##}", login_phone);
                else
                {
                    MessageBox.Show("Некорректный номер телефона");
                    return;
                }

                string forconnect = "Provider=SQLNCLI11.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=Recycling;Data Source=(local);Initial File Name=\"\";Server SPN=\"\"";
                OleDbConnection con = new OleDbConnection(forconnect);
                con.Open();

                OleDbCommand com_driver = new OleDbCommand("select * from Driver", con);
                OleDbDataReader cursor_driver = com_driver.ExecuteReader();
                while (cursor_driver.Read())
                {
                    if ((cursor_driver["Phonenum"].ToString() == login) && (cursor_driver["_pass_word_"].ToString() == password))
                    {                       
                        //ищу соответсвующий номер машины по номеру телефона водителя
                        OleDbCommand com_crew = new OleDbCommand("select CarNumber, Driver from Crew", con);
                        OleDbDataReader cursor_crew = com_crew.ExecuteReader();
                        string crew_num = "";
                        while (cursor_crew.Read())
                        {                                                                                 
                            if (cursor_crew["Driver"].ToString() == cursor_driver["innDriver"].ToString())
                                crew_num = cursor_crew["CarNumber"].ToString();
                        }
                        cursor_driver.Close();
                        cursor_crew.Close();
                        con.Close();

                        Страница_водителя newform = new Страница_водителя(crew_num, this);
                        text_Login.Text = "";
                        text_Password.Text = "";
                        this.Hide();                        
                        newform.Show();
                        return;
                    }
                }                   
                //если мы здесь, значит данные неправильные 
                cursor_driver.Close();
                con.Close();
                MessageBox.Show("Неверный номер телефона или пароль");
            }
        }

        private void rbut_I_am_driver_CheckedChanged(object sender, EventArgs e)
        {
            label_log.Text = "Номер телефона";
        }

        private void rbut_I_am_admin_CheckedChanged(object sender, EventArgs e)
        {            
            label_log.Text = "Логин";                  
        }
    }
}
