using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Image = System.Drawing.Image;

namespace Interactive_FairyTales
{
    public partial class CatalogOfFairyTales : Form
    {
        public CatalogOfFairyTales() => InitializeComponent();

        // Строка подключения
        public static string ConnectString = "Data Source=PC-LEONID29\\SQLEXPRESS;Integrated Security=True";

        private void CatalogOfFairyTales_Load(object sender, EventArgs e)
        {
            Table.Controls.Clear(); Table.AutoScroll = true; Table.HorizontalScroll.Visible = false; Table.SuspendLayout(); DataTable DATA = new DataTable();

            using (SqlConnection Connection = new SqlConnection(ConnectString))
            { Connection.Open(); using (SqlCommand CMD = new SqlCommand($"EXEC [Interactive_FairyTales].[dbo].[FairyTales_ALL]", Connection)) using (SqlDataReader Reader = CMD.ExecuteReader()) DATA.Load(Reader); Connection.Close(); }

            for (int I1 = 0; I1 < DATA.Rows.Count; I1++)
            {
                Panel Main = new Panel { Size = new Size(200, 300), BackgroundImageLayout = ImageLayout.Stretch, BorderStyle = BorderStyle.FixedSingle, Name = (string)DATA.Rows[I1][0] };
                {
                    byte[] Imaged = (byte[])DATA.Rows[I1][2];
                    PictureBox PictureFairyTales = new PictureBox { Size = new Size(Main.Width - 20, Main.Height - 70), BorderStyle = BorderStyle.Fixed3D, BackgroundImageLayout = ImageLayout.Stretch, Left = 10, Top = 10, Name = (string)DATA.Rows[I1][0] };
                    if (Imaged == null) PictureFairyTales.BackgroundImage = Properties.Resources.MissingPhoto; else using (MemoryStream MS = new MemoryStream(Imaged, 0, Imaged.Length)) { MS.Write(Imaged, 0, Imaged.Length); PictureFairyTales.BackgroundImage = Image.FromStream(MS, true, true); }

                    Label NameFairyTales = new Label { Size = new Size(Main.Width - 20, 35), BorderStyle = BorderStyle.Fixed3D, Left = 10, Top = Main.Height - 50, Font = new Font("Times New Roman", 12), TextAlign = ContentAlignment.MiddleCenter, Text = (string)DATA.Rows[I1][1], Name = (string)DATA.Rows[I1][0] };

                    PictureFairyTales.Click += FairyTales_Click; NameFairyTales.Click += FairyTales_Click; Main.Controls.Add(PictureFairyTales); Main.Controls.Add(NameFairyTales);
                }
                Main.Click += FairyTales_Click; Table.Controls.Add(Main);
            }

            Table.ResumeLayout(true);
        }

        private static void FairyTales_Click(object sender, EventArgs e)
        {
            var Element_Panel = new Panel(); var Element_PictureBox = new PictureBox(); var Element_Label = new Label(); string Named = "";

            switch (sender.GetType().ToString())
            {
                case "System.Windows.Forms.Panel": Element_Panel = (Panel)sender; Named = Element_Panel.Name; break;
                case "System.Windows.Forms.PictureBox": Element_PictureBox = (PictureBox)sender; Named = Element_PictureBox.Name; break;
                case "System.Windows.Forms.Label": Element_Label = (Label)sender; Named = Element_Label.Name; break;
            }

            FairyTale.ID = Named; new FairyTale().ShowDialog();
        }
    }
}
