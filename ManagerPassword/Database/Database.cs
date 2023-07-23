using ManagerPassword.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManagerPassword.Database
{
    class Database
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PNAU4VT;Initial Catalog=ManagerPassword; Integrated Security=true"); //Параметры на подключение к базе данных
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        public static DataTable SearchUserData(string query)
        {
            return FillDataAdapter(query);
        }
        public static DataTable FillDataAdapter(string query)
        {
            Database database = new Database();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());
            sqlDataAdapter.SelectCommand = sqlCommand;
            try
            {
                sqlDataAdapter.Fill(dataTable);
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка выполнения sql запроса. Ошибка: {sqlEx.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return dataTable;
        }
        public static void AddElemUserData(string query)
        {
            FillDataAdapter(query);
        }
        public static List<UserData> GetListUserData(string query)
        {
            DataTable dataTable = FillDataAdapter(query);
            List<UserData> userDatas = new List<UserData>();
            UserData userData;
            for (int index = 0; index < dataTable.Rows.Count; ++index)
            {
                string title1 = dataTable.Rows[index][1].ToString();
                userData = new UserData
                {
                    id = (int)dataTable.Rows[index][0],
                    title = dataTable.Rows[index][2].ToString(),
                    username = dataTable.Rows[index][3].ToString(),
                    email = dataTable.Rows[index][4].ToString(),
                    url = dataTable.Rows[index][5].ToString(),
                    password = Encryption.DecryptionPwd(dataTable.Rows[index][6].ToString()),
                    note = dataTable.Rows[index][7].ToString()
                };
                userDatas.Add(userData);
            }
            return userDatas;
        }
    }
}
