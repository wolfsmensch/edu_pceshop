using System;
using System.Data;

using System.Configuration;
using System.Data.SqlClient;

namespace PC_eShop
{
    public class DataBase
    {
        // Параметры работы с базой данных
        protected class Params
        {
            public static SqlConnection connection = null;          // Подключение
            public static string dataBaseParam = String.Empty;      // Параметры подключения
            public static SqlCommand command = null;                // Объект SQL комманд

            public static bool isConnect = false;
        }

        // Подключение к БД
        private static void Connect()
        {
            if (Params.isConnect)
                return;

            Params.dataBaseParam = ConfigurationManager.ConnectionStrings["PC_eShop"].ConnectionString;
            Params.connection = new SqlConnection(Params.dataBaseParam);

            Params.command = new SqlCommand();
            Params.command.Connection = Params.connection;

            Params.isConnect = true;
        }

        // Выполнение SQL запроса на получение данных
        public static SqlDataReader readData(string sql)
        {
            SqlDataReader reader = null;

            Connect();
            if (Params.connection.State != ConnectionState.Open)
                Params.connection.Open();

            Params.command.CommandText = sql;
            reader = Params.command.ExecuteReader();

            return reader;
        }

        // Выполнение SQL запроса на добавление/изменение/удаление данных (не должно возвращать результат)
        public static void execSql(string sql)
        {
            Connect();
            if (Params.connection.State != ConnectionState.Open)
                Params.connection.Open();

            Params.command.CommandText = sql;
            Params.command.ExecuteNonQuery();
        }
    }

}
