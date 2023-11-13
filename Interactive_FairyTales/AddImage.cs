using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Interactive_FairyTales
{
    class AddImage
    {
        public AddImage()
        {
            // Сохранение изображения
            string filename = @"E:\357.jpg"; byte[] imageData;
            using (FileStream fs = new FileStream(filename, FileMode.Open)) { imageData = new byte[fs.Length]; fs.Read(imageData, 0, imageData.Length); }

            using (SqlConnection SQL_Connection = new SqlConnection(CatalogOfFairyTales.ConnectString))
            {
                SQL_Connection.Open(); SqlCommand SQL_Command = SQL_Connection.CreateCommand();
                string Request = $"INSERT INTO [Interactive_FairyTales].[dbo].[Images] VALUES ('I0018',@ImageData);"; // SQL-запрос
                SQL_Command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000); SQL_Command.Parameters["@ImageData"].Value = imageData;
                SQL_Command.CommandText = Request; SQL_Command.ExecuteNonQuery(); SQL_Connection.Close();
            }
        }
    }
}