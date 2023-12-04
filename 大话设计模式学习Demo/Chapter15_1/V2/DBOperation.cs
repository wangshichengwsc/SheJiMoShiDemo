using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Chapter15_1.V2
{
    /// <summary>
    /// 数据库操作对象
    /// </summary>
    public class DBOperation
    {
        string dbType = "SQLServer";
        public IDept CreateDept()
        {
            IDept dept= null;
            switch (dbType)
            {
                case "SQLServer":
                   dept=  new SqlServerDept();
                    break;
                case "MySql":
                    dept = new MySqlDept();
                    break;
                default:
                    break;
            }
            return dept;
        }

        public IUser CreateUser()
        {
            IUser user = null;
            switch (dbType)
            {
                case "SQLServer":
                    user = new SqlServerUser();
                    break;
                case "MySql":
                    user = new MySqlUser();
                    break;
                default:
                    break;
            }
            return user;
        }
    }
}
