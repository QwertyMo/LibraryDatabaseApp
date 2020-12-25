using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDatabase.model;
using MySql.Data.MySqlClient;

namespace LibraryDatabase {
    public class MySQLUtil {

        private MySqlConnection connection { get; set; }

        public MySQLUtil() {
            connection = openConnection();

        }

        private MySqlConnection openConnection() {
            try {
                string connectionString ="server = 192.168.31.12; user = superuser; password = Trixxz44; database = library; port = 3306";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            } catch{
                return null;
            }
        }

        public void closeConnection() {
            connection.Close();
        }

        public List<Book> getBooks(int filter_id, string name, int id, string publishing_house) {
            List<Book> list = new List<Book>();
            string query = "SELECT * FROM books_info WHERE COPY_ID IS NOT NULL ";
            switch(filter_id) {
                case 1:
                    query += "AND AVAILABLE = \"На руках\"" ;
                    break;
                case 2:
                    query += "AND AVAILABLE = \"Имеется\"" ;
                    break;
                case 3:
                    query += "AND AVAILABLE = \"Потеряна\" ";
                    break;
            }
            if(!name.Equals("")) query += "AND NAME LIKE '%" + name + "%'" ;
            if(id != -1) query += "AND COPY_ID =" + id + " ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(
                query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            foreach(DataRow i in data.Rows) {
                list.Add(new Book(
                        Int32.Parse(i[0].ToString()),
                        Int32.Parse(i[1].ToString()), 
                        i[2].ToString(),
                        Int32.Parse(i[3].ToString()),
                        Int32.Parse(i[4].ToString()),
                        Int32.Parse(i[5].ToString()), 
                        i[6].ToString(), 
                        i[7].ToString(), 
                        i[8].ToString(), 
                        i[9].ToString(), 
                        i[10].ToString(),
                        i[11].ToString()
                    ));
            }
            return list;
        }

        public bool isUserFired(string id) {
            try {
                MySqlDataAdapter adapter = new MySqlDataAdapter(
                "SELECT IF(DISMISSAL_DATE IS NOT NULL, TRUE, FALSE) FROM STAFF WHERE STAFF_ID = " + id.ToString() + "", connection);
                
                DataTable data = new DataTable();
                adapter.Fill(data);
                if(data.Rows.Count == 1 && data.Rows[0][0].ToString().Equals("1")) return true;
                else return false;
            } catch {
                return false;
            }
        }

        public bool checkPass(string id, string pass) {
            try {
                MySqlDataAdapter adapter = new MySqlDataAdapter(
                "SELECT SHA2(\"" + pass + "\",256) = PASSWORD FROM STAFF WHERE STAFF_ID = " + id.ToString() + "", connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if(data.Rows.Count == 1 && data.Rows[0][0].ToString().Equals("1")) return true;
                else return false;
            } catch {
                return false;
            }
        }

        public Staff getUser(string id) {
            MySqlDataAdapter adapter = new MySqlDataAdapter(
                "SELECT * FROM staff_info WHERE STAFF_ID = " + id.ToString() + "", connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return new Staff(
                Int32.Parse(data.Rows[0][0].ToString()),
                data.Rows[0][1].ToString(),
                data.Rows[0][2].ToString(),
                data.Rows[0][3].ToString(),
                data.Rows[0][4].ToString(),
                data.Rows[0][5].ToString(),
                data.Rows[0][6].ToString(),
                data.Rows[0][7].ToString(),
                data.Rows[0][8].ToString(),
                data.Rows[0][9].ToString()
               );
        }
    }
}
