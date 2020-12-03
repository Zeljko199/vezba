using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class MenuItemRepository
    {
        public List<MenuItem> GetAllMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString)){
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM MenuItems";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    MenuItem item = new MenuItem(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetDouble(3));

                    menuItems.Add(item); //U listu smo dodali objekat koji sadrzi red iz tabele
                }
            }

            return menuItems;
        }
        public int InsertMenuItem(MenuItem item)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
            
                int result = 0;
            sqlConnection.Open();

            SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                
                command.CommandText=string.Format(
                "INSERT INTO MenuItems VALUES ('{0}','{1}',{2},'{3}')",item.Id,item.Title,item.Description,item.Price)

            return result;
            }
        }
    }
}
