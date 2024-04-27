using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace DataBase_App
{
    public partial class login_up : Form
    {
        DataBase dataBase = new DataBase();

        public login_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '●';
            pictureBox3.Visible = false;

            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBase_Form frm1 = new DataBase_Form();

                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Такого аккаунта не существует!\nВы претендуете на роль получения бана!", "Дядя петя ты дурак?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_up_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataBase.closeConnection();
            this.Close();
        }
    }
}
