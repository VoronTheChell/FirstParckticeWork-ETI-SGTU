using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_App
{
    public partial class Add_Form : Form
    {
        DataBase dataBase = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var type = textBox_type2.Text;
            var count = textBox_count2.Text;
            var postav = textBox_postavchik2.Text;

            int price;

            if (int.TryParse(textBox_price2.Text, out price))
            {
                var addQuaery = $"insert into test_db (type_of, count_of, postavka, price) values ('{type}','{count}','{postav}','{price}')";

                var command = new SqlCommand(addQuaery, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            textBox_count2.Text = "";
            textBox_postavchik2.Text = "";
            textBox_price2.Text = "";
            textBox_type2.Text = "";
        }

        private void Add_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataBase.closeConnection();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь вы можете вписать данные для добавления в таблицу.\n\nЗдесь существует 4 столбика: \n    * Тип товара - название/тип товара, которые мы хотим добавить.\n    * Колличество - колличество товаров необходимые для закупки.\n      * Паставщик - название/номер поставщика от которого мы хотим заказать товар.\n      * Цена - общая ценна за закупку товара.", "ИНФОРМАЦИЯ ПО ЗАПОЛНЕНИЮ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
