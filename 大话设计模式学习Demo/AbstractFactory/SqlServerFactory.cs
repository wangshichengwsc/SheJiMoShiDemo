using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 操作sqlserver数据库的类，继承数据库接口
    /// </summary>
    class SqlServerFactory : IFactory
    {
        public IUserHelper CreateUserHelper()
        {
            return new SqlServerUserHelper();
        }
    }
}
