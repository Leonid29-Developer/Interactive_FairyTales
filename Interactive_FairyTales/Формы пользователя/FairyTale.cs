using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactive_FairyTales
{
    public partial class FairyTale : Form
    {
        public FairyTale() => InitializeComponent();

        public static string ID { get; set; }

        private int Page = 0;

        private DataTable DATA = new DataTable();

        private void FairyTale_Load(object sender, EventArgs e)
        {
            using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
            {
                SQL_Connection.Open(); string Request = $"EXEC [Interactive_FairyTales].[dbo].[FairyTale_Name] '{ID}'"; // SQL-запрос
                SqlCommand Command = new SqlCommand(Request, SQL_Connection); SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read()) Text = $"Сказка «{(string)Reader.GetValue(0)}»"; SQL_Connection.Close();
            }

            using (SqlConnection Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
            {
                Connection.Open(); using (SqlCommand CMD = new SqlCommand($"EXEC [Interactive_FairyTales].[dbo].[FairyTale_Pages] '{ID}'", Connection))
                using (SqlDataReader Reader = CMD.ExecuteReader()) DATA.Load(Reader); Connection.Close();
            }

            PageOutput();
        }

        private void PageOutput()
        {
            PagesNumbers.Text = $"{Page+1} / {DATA.Rows.Count}";

            FairyTale_Text.Text = (string)DATA.Rows[Page][1]; PanelForText.AutoScroll = false; PanelForText.AutoScroll = true;
            if (DATA.Rows[Page][2] == DBNull.Value) FairyTale_Picture.BackgroundImage = null;
            else
            {
                byte[] Imaged = (byte[])DATA.Rows[Page][2];
                using (MemoryStream MS = new MemoryStream(Imaged, 0, Imaged.Length)) { MS.Write(Imaged, 0, Imaged.Length); FairyTale_Picture.BackgroundImage = Image.FromStream(MS, true, true); }
            }
        }

        private void PagePrev_Click(object sender, EventArgs e) { if (Page > 0) Page--; PageOutput(); }

        private void PageNext_Click(object sender, EventArgs e) { if (Page < DATA.Rows.Count-1) Page++; PageOutput(); }

        private void FairyTale_SizeChanged(object sender, EventArgs e)
        {
            if ((int)((double)PanelForText.Width / 32.0) >0)FairyTale_Text.Font = new Font("Times New Roman", (int)((double)PanelForText.Width / 32.0));
                FairyTale_Picture.Size = new Size(FairyTale_Picture.Height, FairyTale_Picture.Height); 
                PanelForText.Size = new Size(Width - FairyTale_Picture.Height - 110, PanelForText.Height); PanelForText.Location = new Point(FairyTale_Picture.Height + 60, PanelForText.Location.Y);
            }
    }
}
