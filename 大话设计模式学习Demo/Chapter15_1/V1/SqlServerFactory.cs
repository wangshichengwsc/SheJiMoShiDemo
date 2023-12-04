using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_1
{
    /// <summary>
    /// sqlserver数据库各个表操作对象的工具类
    /// </summary>
    public class SqlServerFactory : IFactory
    {
        IDept IFactory.CreateDept()
        {
            return new SqlServerDept();
        }

        IUser IFactory.CreateUser()
        {
            return new SqlServerUser();
        }
    }
}
