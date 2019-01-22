
using SqlSugar;
using DbType = SqlSugar.DbType;

namespace Think.Data
{
    public class DemoBase
    {
        public static SqlSugarClient GetInstance()
        {
            var str = System.Configuration.ConfigurationManager.AppSettings["SqlConnection"];
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = str,
                DbType = DbType.SqlServer, //必填   
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute  // Attribute用于DbFirst  从数据库生成model的
                                                     //InitKeyType = InitKeyType.SystemTable SystemTable用于Codefirst 从model库生成数据库表的
            }); return db;
        }
    }
}