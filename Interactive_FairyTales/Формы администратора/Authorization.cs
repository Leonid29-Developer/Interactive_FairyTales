using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Interactive_FairyTales
{
    public partial class Authorization : Form
    {
        public Authorization() => InitializeComponent();

        private void Button_Input_Click(object sender, EventArgs e)
        {
            bool T = false;
            if (TB_Login.Text != "" & TB_Password.Text != "")
            {
                using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
                {
                    SQL_Connection.Open();
                    string Request = $"EXEC [Interactive_FairyTales].[dbo].[Authorization] '{TB_Login.Text}','{TB_Password.Text}';"; // SQL-запрос
                    SqlCommand Command = new SqlCommand(Request, SQL_Connection); SqlDataReader Reader = Command.ExecuteReader();
                    T = Reader.HasRows; SQL_Connection.Close();
                }

                if (T == true) { Hide(); new FairyTale_Editor().ShowDialog(); Close(); }
            }
            else T = false; if (T == false) MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e) => System.Windows.Forms.Application.OpenForms["CatalogOfFairyTales"].Show();

        // Кнопка быстрой авторизации
        private void pictureBox1_Click(object sender, EventArgs e) { TB_Login.Text = "Fahanoell"; TB_Password.Text = "NhohzUZE"; }
    }
}
