using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace PaternsExam._3
{
    /*3. Вам необходимо установить единое "окно" 
     * подключения к БД Oracle из всего приложения, 
     * т.к. количество подключений ограниченно нужно 
     * выбрать патерн, который бы помог реализовать 
     * это ограничение. Также есть необходимость хранить 
     * некоторые персональные данные пользователя 
     * (Имя, логин, доступ к модулям (string))
*/
    public class Singleton
    {
        static SqlConnection sqlConnection;
        static string connectionString = "";
        static string Name { get; set; }
        static string Login { get; set; }
        static int AvailabilityLevel { get; set; }

        public static SqlConnection CreateOrConnect()
        {
            if (sqlConnection == null)
                sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}
