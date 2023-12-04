using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// mysql数据库操作类，类继承接口 数据库操作接口
    /// </summary>
    class MySqlFactory : IFactory
    {
        /// <summary>
        /// 创建user帮助类的方法，应为已经知道当前数据库操作类时mysql数据库操作类，所以直接返回对应的mysql类型的user帮助类 mysqluserhelper
        /// </summary>
        /// <returns></returns>
        public IUserHelper CreateUserHelper()
        {
            return new MySqlUserHelper();
        }
    }
}
