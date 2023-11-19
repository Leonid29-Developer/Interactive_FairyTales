using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Interactive_FairyTales
{
    public partial class PagesOfFairyTales_Editor : Form
    {
        public PagesOfFairyTales_Editor() => InitializeComponent();

        public static string ID { get; set; }

        private string FairyTale_Name;

        private int Page = 0;

        private DataTable DATA = new DataTable();

        private void PagesOfFairyTales_Editor_Load(object sender, EventArgs e)
        {
            using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
            {
                SQL_Connection.Open(); string Request = $"EXEC [Interactive_FairyTales].[dbo].[FairyTale_Name] '{ID}'"; // SQL-запрос
                SqlCommand SQL_Command1 = new SqlCommand(Request, SQL_Connection); SqlDataReader Reader = SQL_Command1.ExecuteReader();
                while (Reader.Read()) FairyTale_Name = (string)Reader.GetValue(0); Text = $"Редактор Страниц Сказки «{FairyTale_Name}»"; SQL_Connection.Close();
            }

            using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
            {
                SQL_Connection.Open(); string Request = $"EXEC [Interactive_FairyTales].[dbo].[PagesNumbers_Update] @FairyTale"; // SQL-запрос
                SqlCommand SQL_Command2 = new SqlCommand(Request, SQL_Connection);
                SQL_Command2.Parameters.Add("@FairyTale", SqlDbType.VarChar, 6); SQL_Command2.Parameters["@FairyTale"].Value = ID;
                SQL_Command2.ExecuteNonQuery(); SQL_Connection.Close();
            }

            PageOutput();
        }

        private void PageOutput()
        {
            DATA = new DataTable(); using (SqlConnection Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
            {
                Connection.Open(); using (SqlCommand CMD = new SqlCommand($"EXEC [Interactive_FairyTales].[dbo].[FairyTale_Pages] '{ID}'", Connection))
                using (SqlDataReader Reader = CMD.ExecuteReader()) 
                { 
                    PageRemove.Enabled = Reader.HasRows; Save_Button.Enabled = Reader.HasRows; PagePrev.Enabled = Reader.HasRows; PageNext.Enabled = Reader.HasRows;
                    PageFairyTale_Picture.Enabled = Reader.HasRows; PageFairyTale_Text.Enabled = Reader.HasRows; DATA.Load(Reader);  
                }  
                Connection.Close();
            }

            if (DATA.Rows.Count > 0)
            {
                if (DATA.Rows.Count == 1) { PagePrev.Enabled = false; PageNext.Enabled = false ; }

                    PageNumber.Text = $"{Page + 1}"; PagesNumbers.Text = $"/ {DATA.Rows.Count}";

                PageFairyTale_Text.Text = (string)DATA.Rows[Page][1]; PanelForText.AutoScroll = false; PanelForText.AutoScroll = true;
                if (DATA.Rows[Page][2] == DBNull.Value) PageFairyTale_Picture.BackgroundImage = null;
                else
                {
                    byte[] Imaged = (byte[])DATA.Rows[Page][2];
                    using (MemoryStream MS = new MemoryStream(Imaged, 0, Imaged.Length)) { MS.Write(Imaged, 0, Imaged.Length); PageFairyTale_Picture.BackgroundImage = Image.FromStream(MS, true, true); }
                }
            }
            else { PageNumber.Text = $"0"; PagesNumbers.Text = $"/ 0"; PageFairyTale_Picture.BackgroundImage = null; PageFairyTale_Text.Text = ""; }
        }

        private void PagePrev_Click(object sender, EventArgs e) { if (Page > 0) Page--; PageOutput(); }

        private void PageNext_Click(object sender, EventArgs e) { if (Page < DATA.Rows.Count - 1) Page++; PageOutput(); }

        private bool PageADD = false;

        private void PageRemove_Click(object sender, EventArgs e)
        {
            if (!PageADD) if (MessageBox.Show($"Уверены что хотите удалить страницу сказки «{FairyTale_Name}»?", "Уведомление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
                    {
                        SQL_Connection.Open(); SqlCommand SQL_Command = SQL_Connection.CreateCommand();
                        string Request = $"EXEC [Interactive_FairyTales].[dbo].[Page_Delete] @FairyTale, @Page_Number"; // SQL-запрос
                        SQL_Command.Parameters.Add("@FairyTale", SqlDbType.VarChar, 6); SQL_Command.Parameters["@FairyTale"].Value = ID;
                        SQL_Command.Parameters.Add("@Page_Number", SqlDbType.VarChar, 4); SQL_Command.Parameters["@Page_Number"].Value = DATA.Rows[Page][0];
                        SQL_Command.CommandText = Request; SQL_Command.ExecuteNonQuery(); SQL_Connection.Close();
                    }

                    MessageBox.Show("Успешно", "Удаление данных", MessageBoxButtons.OK, MessageBoxIcon.Information);Page = 0; PageOutput(); 
                }
                else MessageBox.Show("Отменено", "Удаление данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PageAdd_Click(object sender, EventArgs e)
        {
            PageNumber.Text = $"{DATA.Rows.Count + 1}"; PagesNumbers.Text = $"/ {DATA.Rows.Count + 1}"; PageFairyTale_Picture.BackgroundImage = null; PageFairyTale_Text.Text = "";

            Save_Button.Enabled = true;  PageFairyTale_Picture.Enabled = true; PageFairyTale_Text.Enabled = true; PageADD = true; Pic_NEW.Visible = true;
        }

        private bool ImageUpdate = false;

        private void Save_Button_Click(object sender, EventArgs e)
        {
            byte[] Imaged = null; if (ImageUpdate) { ImageConverter converter = new ImageConverter(); Imaged = (byte[])converter.ConvertTo(PageFairyTale_Picture.BackgroundImage, typeof(byte[])); }

            try
            {
                if (Convert.ToInt32(PageNumber.Text) > 0)
                {
                    bool ADD = true; using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
                    {
                        string Request = $"EXEC [Interactive_FairyTales].[dbo].[Page_Number] @FairyTale, @Page_Number"; // SQL-запрос
                        SQL_Connection.Open(); SqlCommand SQL_Command = new SqlCommand(Request, SQL_Connection);
                        SQL_Command.Parameters.Add("@FairyTale", SqlDbType.VarChar, 6); SQL_Command.Parameters["@FairyTale"].Value = ID;
                        SQL_Command.Parameters.Add("@Page_Number", SqlDbType.Int); SQL_Command.Parameters["@Page_Number"].Value = Convert.ToInt32(PageNumber.Text);
                        SqlDataReader Reader = SQL_Command.ExecuteReader(); ADD = Reader.HasRows; SQL_Connection.Close();
                    }

                    if (!ADD)
                    {
                        if (PageADD) using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
                            {
                                SQL_Connection.Open(); SqlCommand SQL_Command = SQL_Connection.CreateCommand();
                                string Request = $"EXEC [Interactive_FairyTales].[dbo].[Page_Add] @FairyTale, @Page_Number, @Image, @Text"; // SQL-запрос
                                SQL_Command.Parameters.Add("@FairyTale", SqlDbType.VarChar, 6); SQL_Command.Parameters["@FairyTale"].Value = ID;
                                SQL_Command.Parameters.Add("@Page_Number", SqlDbType.Int); SQL_Command.Parameters["@Page_Number"].Value = Convert.ToInt32(PageNumber.Text);
                                SQL_Command.Parameters.Add("@Image", SqlDbType.Image, 1000000); SQL_Command.Parameters["@Image"].Value = Imaged;
                                SQL_Command.Parameters.Add("@Text", SqlDbType.NVarChar, 1000000); SQL_Command.Parameters["@Text"].Value = PageFairyTale_Text.Text;
                                SQL_Command.CommandText = Request; SQL_Command.ExecuteNonQuery(); SQL_Connection.Close();
                            }
                        else using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
                            {
                                SQL_Connection.Open(); SqlCommand SQL_Command = SQL_Connection.CreateCommand();
                                string Request = $"EXEC [Interactive_FairyTales].[dbo].[Page_Update] @FairyTale, @Page, @Page_Number, @Image, @Text"; // SQL-запрос
                                SQL_Command.Parameters.Add("@FairyTale", SqlDbType.VarChar, 6); SQL_Command.Parameters["@FairyTale"].Value = ID;
                                SQL_Command.Parameters.Add("@Page", SqlDbType.VarChar, 4); SQL_Command.Parameters["@Page"].Value = DATA.Rows[Page][0];
                                SQL_Command.Parameters.Add("@Page_Number", SqlDbType.Int); SQL_Command.Parameters["@Page_Number"].Value = Convert.ToInt32(PageNumber.Text);
                                SQL_Command.Parameters.Add("@Image", SqlDbType.Image, 1000000); if (ImageUpdate) SQL_Command.Parameters["@Image"].Value = Imaged; else SQL_Command.Parameters["@Image"].Value = DATA.Rows[Page][2];
                            SQL_Command.Parameters.Add("@Text", SqlDbType.NVarChar, 1000000); SQL_Command.Parameters["@Text"].Value = PageFairyTale_Text.Text; 
                                SQL_Command.CommandText = Request; SQL_Command.ExecuteNonQuery(); SQL_Connection.Close();
                            }

                        MessageBox.Show("Успешно", "Сохранение данных", MessageBoxButtons.OK, MessageBoxIcon.Information); PageADD = false; Pic_NEW.Visible = false; Page = 0;PageOutput(); 
                    }
                    else MessageBox.Show("Данный номер страницы занят иной страницей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Некорректный номер страницы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FairyTale_Picture_Click(object sender, EventArgs e)
        { DialogResult Resource = OpenFile.ShowDialog(); if (Resource == DialogResult.OK) PageFairyTale_Picture.BackgroundImage = Image.FromFile(OpenFile.FileName); ImageUpdate = true; }
    }
}