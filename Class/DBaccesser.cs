using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace contacts_management_app.Class
{
    internal class DBaccesser
    {

        public DataTable GetData(string sqlQuery = @"SELECT * FROM contacts")
        {
            var table = new DataTable();

            // 接続文字列の取得
            //var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
            var connectionString = "Data Source=DSP417;Initial Catalog=test_take;User ID=sql_takemiya;Password=sql_takemiya";

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    // データベースの接続開始
                    connection.Open();

                    // SQLの設定
                    command.CommandText = sqlQuery; // @"SELECT * FROM contacts";

                    // SQLの実行
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
                finally
                {
                    // データベースの接続終了
                    connection.Close();
                }
            }

            return table;
        }
    }
}
