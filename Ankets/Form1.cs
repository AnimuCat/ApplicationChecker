using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ankets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] applicationButtons;
        string[] dataFromBD = new string[7];
        int id;

        private void Form1_Load(object sender, EventArgs e)
        {
            BD bd = new BD(); //объект БД
            DataTable table = new DataTable(); // Таблица нужна для начальной инициализации кнопок
            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Эта хуита для чтения данных из БД
            MySqlCommand command = new MySqlCommand("SELECT `id`, `name` FROM `applications` WHERE `Approved` IS NULL", bd.getConnection()); //Команда к БД

            bd.openBD(); //Открываем БД

            adapter.SelectCommand = command; //Запускаем команду
            adapter.Fill(table); //Заполняем таблицу для инициализации
            MySqlDataReader reader = command.ExecuteReader(); //Обозначем ридер
            string[] rowsFromTable = new string[table.Rows.Count]; //Массив имён для кнопок
            string[] idS = new string[table.Rows.Count];
            int j = 0; //простой счётчик

            while (reader.Read()) //Пока читает, заносит имена в массив
            {
                rowsFromTable[j] = reader.GetString("name");
                idS[j] = reader.GetString("id");
                j++;
            }

            bd.closeBD(); //Закрываем БД. Мы же выносим мусор за собой?

            int ran = table.Rows.Count; //Количество кнопок равно количеству строк имён из БД
            applicationButtons = new Button[ran]; //Массив кнопок
            int posX, posY; //позиции Х и У
            posX = posY = 10; //Начальная позиция

            for(int i = 0; i < ran; i++) //Цикл создания кнопок
            {
                applicationButtons[i] = new Button(); 
                applicationButtons[i].BackColor = Color.LightGray;
                applicationButtons[i].ForeColor = Color.Black;
                applicationButtons[i].Size = new Size(110, 25);
                applicationButtons[i].Location = new Point(posX, posY);
                applicationButtons[i].Text = rowsFromTable[i]; //Текст на кнопке как имя из БД
                applicationButtons[i].Name = $"buttonApp{i}";
                applicationButtons[i].Tag = idS[i];
                applicationButtons[i].Click += new EventHandler(loadApplication); //Подписываемся на событие по клику
                this.Controls.Add(applicationButtons[i]);
                posX += 115;
                if(applicationButtons[i].Location.X > (this.Size.Width - 200))
                {
                    posY += 30;
                    posX = 10;
                }
            }


            ButtonApproved.Click += new EventHandler(LoadApplications);
            ButtonMeeting.Click += new EventHandler(LoadApplications);
            ButtonNotApproved.Click += new EventHandler(LoadApplications);
        }

        private void loadApplication(object sender, EventArgs e)
        {
            Button a = (Button)sender;

            BD bd = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `id`, `name`, `contacts`, `age`, `about`, `why`, `rules` FROM `applications` WHERE `Approved` IS NULL AND `id`=@nm", bd.getConnection());
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = a.Tag;

            bd.openBD();

            MySqlDataReader reader = command.ExecuteReader();
            
            id = Convert.ToInt32(a.Tag);

            while (reader.Read())
            {
                for(int i = 0; i < 6; i++)
                {
                    dataFromBD[i] = Convert.ToString(reader.GetString(i+1));
                }
            }

            reader.Close();
            bd.closeBD();

            foreach (Button i in applicationButtons)
            {
                i.Hide();
            }

            ButtonApproved.Show();
            ButtonMeeting.Show();
            ButtonNotApproved.Show();

            //Тут тоже костыль, можно вместо дроча с 6 строками, сделать цикл, пробегающийся по двумерному массиву -
            // - 1 строка это имена столбцов, а 2 - сами данные. Пока что только так
            ApplicationTextBox.Visible = true;
            ApplicationTextBox.Text += $"Имя: {dataFromBD[0]}\n\n";
            ApplicationTextBox.Text += $"Контакты: {dataFromBD[1]}\n\n";
            ApplicationTextBox.Text += $"Возраст: {dataFromBD[2]}\n\n";
            ApplicationTextBox.Text += $"О себе: {dataFromBD[3]}\n\n";
            ApplicationTextBox.Text += $"Причина: {dataFromBD[4]}\n\n";
            ApplicationTextBox.Text += $"Правила: {dataFromBD[5]}\n";

        }

        private void ButtonApproved_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `applications` SET `Approved` = 'Да' WHERE `id` = @nm", bd.getConnection());
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = id;

            bd.openBD();

            command.ExecuteNonQuery();

            bd.closeBD();
        }

        private void LoadApplications(object sender, EventArgs e)
        {
            foreach(Button i in applicationButtons)
            {
                i.Show();
                if (i.Tag.ToString() == id.ToString())
                {
                    i.Dispose();
                }
            }

            ApplicationTextBox.Clear();
            ApplicationTextBox.Hide();
            ButtonApproved.Hide();
            ButtonMeeting.Hide();
            ButtonNotApproved.Hide();
        }

        private void ButtonMeeting_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `applications` SET `Approved` = 'Собес' WHERE `id` = @nm", bd.getConnection());
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = id;

            bd.openBD();

            command.ExecuteNonQuery();

            bd.closeBD();
        }

        private void ButtonNotApproved_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `applications` SET `Approved` = 'Нет' WHERE `id` = @nm", bd.getConnection());
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = id;

            bd.openBD();

            command.ExecuteNonQuery();

            bd.closeBD();
        }
    }
}
