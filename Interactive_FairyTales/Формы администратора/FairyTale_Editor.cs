using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Interactive_FairyTales
{
    public partial class FairyTale_Editor : Form
    {
        public FairyTale_Editor() => InitializeComponent();

        private DataTable DATA = new DataTable();

        private void FairyTale_Editor_Load(object sender, EventArgs e) => Update_ListFairyTales();

        private void Update_ListFairyTales()
        {
            List_FairyTales.Items.Clear(); DATA = new DataTable();

            using (SqlConnection Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
            { Connection.Open(); using (SqlCommand CMD = new SqlCommand($"EXEC [Interactive_FairyTales].[dbo].[FairyTales_ALL]", Connection)) using (SqlDataReader Reader = CMD.ExecuteReader()) DATA.Load(Reader); Connection.Close(); }

            for (int I1 = 0; I1 < DATA.Rows.Count; I1++) List_FairyTales.Items.Add((string)DATA.Rows[I1][1]); List_FairyTales.Items.Add("Добавить новую сказку"); List_FairyTales.SelectedIndex = List_FairyTales.Items.Count - 1;
        }

        private void List_FairyTales_SelectedIndexChanged(object sender, EventArgs e)
        {
            FairyTale_Name.Text = ""; FairyTale_Picture.BackgroundImage = null;

            if (List_FairyTales.Items[List_FairyTales.SelectedIndex].ToString() == "Добавить новую сказку")
            {
                Edit_Button.Enabled = false; Remove_Button.Enabled = false;
            }
            else
            {
                Edit_Button.Enabled = true; Remove_Button.Enabled = true; FairyTale_Name.Text = (string)DATA.Rows[List_FairyTales.SelectedIndex][1];
                if (DATA.Rows[List_FairyTales.SelectedIndex][2] == DBNull.Value) FairyTale_Picture.BackgroundImage = null;
                else
                {
                    byte[] Imaged = (byte[])DATA.Rows[List_FairyTales.SelectedIndex][2];
                    using (MemoryStream MS = new MemoryStream(Imaged, 0, Imaged.Length)) { MS.Write(Imaged, 0, Imaged.Length); FairyTale_Picture.BackgroundImage = Image.FromStream(MS, true, true); }
                }
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        { PagesOfFairyTales_Editor.ID = DATA.Rows[List_FairyTales.SelectedIndex][0].ToString(); new PagesOfFairyTales_Editor().ShowDialog(); }
        
        private bool ImageUpdate = false;

        private void Save_Button_Click(object sender, EventArgs e)
        {
            byte[] Imaged = null; if (ImageUpdate) { ImageConverter converter = new ImageConverter(); Imaged = (byte[])converter.ConvertTo(FairyTale_Picture.BackgroundImage, typeof(byte[])); }

            if (List_FairyTales.Items[List_FairyTales.SelectedIndex].ToString() == "Добавить новую сказку")
                using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
                {
                    SQL_Connection.Open(); SqlCommand SQL_Command = SQL_Connection.CreateCommand();
                    string Request = $"EXEC [Interactive_FairyTales].[dbo].[FairyTale_Add] @Name, @ImageData"; // SQL-запрос
                    SQL_Command.Parameters.Add("@Name", SqlDbType.NVarChar, 50); SQL_Command.Parameters["@Name"].Value = FairyTale_Name.Text;
                    SQL_Command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000); if (ImageUpdate) SQL_Command.Parameters["@ImageData"].Value = Imaged; else SQL_Command.Parameters["@ImageData"].Value = DBNull.Value;
                    SQL_Command.CommandText = Request; SQL_Command.ExecuteNonQuery(); SQL_Connection.Close();
                }
            else using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
                {
                    SQL_Connection.Open(); SqlCommand SQL_Command = SQL_Connection.CreateCommand();
                    string Request = $"EXEC [Interactive_FairyTales].[dbo].[FairyTale_Update] @ID, @Name, @ImageData"; // SQL-запрос
                    SQL_Command.Parameters.Add("@ID", SqlDbType.VarChar, 6); SQL_Command.Parameters["@ID"].Value = DATA.Rows[List_FairyTales.SelectedIndex][0];
                    SQL_Command.Parameters.Add("@Name", SqlDbType.NVarChar, 50); SQL_Command.Parameters["@Name"].Value = FairyTale_Name.Text;
                    SQL_Command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000); if (ImageUpdate) SQL_Command.Parameters["@ImageData"].Value = Imaged; else SQL_Command.Parameters["@ImageData"].Value = DATA.Rows[List_FairyTales.SelectedIndex][2];
                    SQL_Command.CommandText = Request; SQL_Command.ExecuteNonQuery(); SQL_Connection.Close();
                }

            MessageBox.Show("Успешно", "Сохранение данных", MessageBoxButtons.OK, MessageBoxIcon.Information); Update_ListFairyTales();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if (List_FairyTales.Items[List_FairyTales.SelectedIndex].ToString() != "Добавить новую сказку")
                if (MessageBox.Show($"Уверены что хотите удалить сказку «{List_FairyTales.Items[List_FairyTales.SelectedIndex]}»?", "Уведомление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
                    {
                        SQL_Connection.Open(); SqlCommand SQL_Command = SQL_Connection.CreateCommand();
                        string Request = $"EXEC [Interactive_FairyTales].[dbo].[FairyTale_Delete] @ID"; // SQL-запрос
                        SQL_Command.Parameters.Add("@ID", SqlDbType.VarChar, 6); SQL_Command.Parameters["@ID"].Value = DATA.Rows[List_FairyTales.SelectedIndex][0];
                        SQL_Command.CommandText = Request; SQL_Command.ExecuteNonQuery(); SQL_Connection.Close();
                    }

                    MessageBox.Show("Успешно", "Удаление данных", MessageBoxButtons.OK, MessageBoxIcon.Information); Update_ListFairyTales();
                }
                else MessageBox.Show("Отменено", "Удаление данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FairyTale_Picture_Click(object sender, EventArgs e)
        { DialogResult Resource = OpenFile.ShowDialog(); if (Resource == DialogResult.OK) FairyTale_Picture.BackgroundImage = Image.FromFile(OpenFile.FileName); ImageUpdate = true; }
    }
}