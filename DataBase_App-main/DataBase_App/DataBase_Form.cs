using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase_App
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class DataBase_Form : Form
    {
        DataBase dataBase = new DataBase();

        int selectdRow;

        public DataBase_Form()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("type_of", "Тип товара");
            dataGridView1.Columns.Add("count_of", "Колличество");
            dataGridView1.Columns.Add("postavka", "Поставщик");
            dataGridView1.Columns.Add("price", "Цена");

            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ClearFields()
        {
            textBox_Ids.Text = "";
            textBox_type.Text = "";
            textBox_count.Text = "";
            textBox_postavshiki.Text = "";
            textBox_price.Text = "";

            textBox_UserID.Text = "";
            textBox_UserLogin.Text = "";
            textBox_UserPass.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RowState.Modified);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryStr = $"select * from test_db";

            SqlCommand command = new SqlCommand(queryStr, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void DataBase_Form_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            ///RefreshDataGrid(dataGridView2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectdRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectdRow];

                textBox_Ids.Text = row.Cells[0].Value.ToString();
                textBox_type.Text = row.Cells[1].Value.ToString();
                textBox_count.Text = row.Cells[2].Value.ToString();
                textBox_postavshiki.Text = row.Cells[3].Value.ToString();
                textBox_price.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btn_Replay_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from test_db where concat (id, type_of, count_of, postavka, price) like '%" + siedBar.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void Update()
        {
            dataBase.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from test_db where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var count = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var postavka = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update test_db set type_of = '{type}', count_of = '{count}', postavka = '{postavka}', price = '{price}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                }
            } 
            
            dataBase.closeConnection();
        }

        private void siedBar_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try { Update(); }
            
            catch { MessageBox.Show("Не возможно сохранить результаты. \nПричина - не были внесены изменения в таблицы со стороны пользователя.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            
        }

        private void Change() //Berserk Delux Duper Edition
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_Ids.Text;
            var type = textBox_type.Text;
            var count = textBox_count.Text;
            var postav = textBox_postavshiki.Text;
            int price;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_price.Text, out price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, type, count, postav, price);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }

                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void информаияПоИнтерфейсуToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь представлена форма, где вы можете: добвлять записи, изменять их, добвлять, а также сохранить результаты изменений!\nТак же вы можете переключаться по таблицам, по специальным вкладкам сверху.", "ИНФОРМАЦИЯ ПО ИНТЕРФЕЙСУ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void информацияПоТаблицамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь существует 4 столбика: \n    * Тип товара - название/тип товара, которые мы хотим добавить. \n    * Колличество - колличество товаров необходимые для закупки. \n      * Паставщик - название/номер поставщика от которого мы хотим заказать товар. \n      * Цена - общая ценна за закупку товара.", "ИНФОРМАЦИЯ ПО ТАБЛИЦАМ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataBase_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataBase.closeConnection();
            this.Close();
        }

        private void сохранитьТаблицуВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            string user = Environment.UserName;

            string file = "C:\\Users\\"+ user +"\\Documents\\mygrid.bin";

            

            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dgv.Columns.Count);
                bw.Write(dgv.Rows.Count);
                foreach (DataGridViewRow dgvR in dgv.Rows)
                {
                    for (int j = 0; j < dgv.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
                MessageBox.Show("Файл сохранен", "УСПЕШНОЕ СОХРАНЕНИЕ ФАЙЛА", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void открытьФайлТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            dgv.Rows.Clear();

            string user = Environment.UserName;

            string file = "C:\\Users\\" + user + "\\Documents\\mygrid.bin";

            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dgv.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dgv.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }

                MessageBox.Show("Файл открыт", "УСПЕШНОЕ ОТКРЫТИЕ ФАЙЛА", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.closeConnection();

            login_up frm_login = new login_up();
            frm_login.Show();
            this.Hide();
        }
    }
}
