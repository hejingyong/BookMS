using System.Data;
using System.Data.SqlClient;

namespace BookMS
{
    public abstract class SqlHelper
    {
        // 连接数据库字符串
        private static readonly string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookDB.mdf;Integrated Security = True; Connect Timeout = 30";

        /// <summary>
        /// 执行增、删、改方法
        /// </summary>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 返回第一行第一列数据的查询方法
        /// </summary>
        /// <returns>返回查询结果的数量</returns>
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// 返回一个DataSet的查询方法
        /// </summary>
        /// <returns>返回一个DataSet结果集</returns>
        public static DataSet ExcuteDataSet(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                // 表示用于填充 DataSet 和更新 SQL Server 数据库的一组数据命令和一个数据库连接
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                //表示数据在内存中的缓存
                DataSet ds = new DataSet();
                sda.Fill(ds);

                return ds;
            }
        }
    }
}
