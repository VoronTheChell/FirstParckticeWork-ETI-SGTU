using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_App
{
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '●';
            pictureBox3.Visible = false;

            textBox_login2.MaxLength = 50;
            textBox_password2.MaxLength = 50;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (checkUser())

            {
                return;
            }

            var login = textBox_login2.Text;
            var password = textBox_password2.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand comamnd = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.openConnection();

            if(comamnd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был успешно создан!", $"Поздравляю пользователь {login}!");
                login_up frm_login = new login_up();
                this.Hide();
                frm_login.ShowDialog();

            }

            else
            {
                MessageBox.Show("Аккаунт не был успешно создан!", $"ОШИБКА РЕГЕСТРАЦИИ!");
            }

            dataBase.closeConnection();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_login2.Text = "";
            textBox_password2.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }


        private Boolean checkUser()
        {
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string quertystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(quertystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("Пользователь уже зарегестрированн!", $"ОШИБКА!");
                return true;
            }

            else
            {
                return false;
            }
        }

        private void log_in_load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '●';
            pictureBox3.Visible = false;
            textBox_password2.MaxLength = 50;
        }

        private void sign_up_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataBase.closeConnection();
            login_up frm_login = new login_up();
            this.Hide();
            frm_login.ShowDialog();
        }

        private void sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataBase.closeConnection();
            login_up frm_login = new login_up();
            this.Hide();
            frm_login.ShowDialog();
        }
    }
}
