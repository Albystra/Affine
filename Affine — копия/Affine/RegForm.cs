using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();


        }

        private void reg_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Введите имя.");
                return;
            }
            if (lastname.Text == "")
            {
                MessageBox.Show("Введите фамилию.");
                return;
            }
            if (userReg.Text == "")
            {
                MessageBox.Show("Введите логин.");
                return;
            }
            if (passReg.Text == "")
            {
                MessageBox.Show("Введите пароль.");
                return;
            }

            if (isUNTaken())
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `lastname`) VALUES (@login, @password, @name, @lastname);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userReg.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passReg.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Aккаунт был создан.");
                this.Hide();
                LogForm logForm = new LogForm();
                logForm.Show();
            }
            else
                MessageBox.Show("Что-то пошло не так - аккаунт не был создан.");

            db.closeConnection();
        }

        public Boolean isUNTaken()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userReg.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с таким логином уже существует.");
                return true;
            }
            else
                return false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogForm logForm = new LogForm();
            logForm.Show();
        }
    }
}
