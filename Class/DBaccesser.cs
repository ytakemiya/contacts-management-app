﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;

namespace contacts_management_app.Class
{
    internal class DBaccesser
    {

        private string connectionString = "Data Source=DSP417;Initial Catalog=test_take;User ID=sql_takemiya;Password=ty21133202";

    ////    public static connectionString_method(strng Dat)
    ////    {
    ////        connectionString_method();
    //          var connectionString = "Data Source=DSP417;Initial Catalog=test_take;User ID=sql_takemiya;Password=sql_takemiya";


    ////    }
        public static DataTable GetData(string sqlQuery = @"SELECT * FROM contacts")
        {
            var table = new DataTable();


            // 接続文字列の取得
            //var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
            var connectionString = "Data Source=DSP417;Initial Catalog=test_take;User ID=sql_takemiya;Password=ty21133202";

            //var builder = new SqlConnectionStringBuilder();
            //builder.DataSource = @"DSP417;
            //builder.InitialCatalog = test_take;
            //builder.UserID = sql_takemiya;
            //builder.Password = sql_takemiya;
            //var connectionString = builder.Tostring();


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
        public static void Insertdata(){

            var table = new DataTable();
            //接続文字列
            var connectionString = "Data Source=DSP417;Initial Catalog=test_take;User ID=sql_takemiya;Password=ty21133202";

            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            try
            {
                // データベースの接続開始
                connection.Open();

                command.CommandText = @"INSERT INTO contacts (ID, NAME, TEL, MAIL, MEMO) VALUES (ID, NAME, TEL, MAIL, MEMO)";
                //command.Parameters.Add(new SqlParameter("@ID", ID));
                //command.Parameters.Add(new SqlParameter("@PASSWORD", password));
                //command.Parameters.Add(new SqlParameter("@ROLE_NAME", role));

                // SQLの実行
                command.ExecuteNonQuery();
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
        public void UpdateData(string NAME, string TEL ,string Mail, string Memo, int ID)
        {
            var table = new DataTable();
            //接続文字列
            //var connectionString = "Data Source=DSP417;Initial Catalog=test_take;User ID=sql_takemiya;Password=sql_takemiya";

            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            try
            {

                // データベースの接続開始
                connection.Open();

                command.CommandText = @"UPDATE contacts SET NAME=@NAME,TEL=@TEL,Mail=@Mail,Memo=@Memo WHERE ID=@ID";
                command.Parameters.Add(new SqlParameter("@ID", ID));
                command.Parameters.Add(new SqlParameter("@NAME", NAME));
                command.Parameters.Add(new SqlParameter("@TEL", TEL));
                command.Parameters.Add(new SqlParameter("@Mail", Mail));
                command.Parameters.Add(new SqlParameter("@Memo", Memo));
                // SQLの実行
                command.ExecuteNonQuery();
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

    }
}
