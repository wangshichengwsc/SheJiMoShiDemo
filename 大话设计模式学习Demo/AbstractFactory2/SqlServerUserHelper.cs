using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    /// <summary>
    /// 使用sqlserver数据库数据的user帮助类
    /// 我的理解之所以有sqlserveruserhelper这样不同的类，可能是因为 sqlserver与mysql的语法有差异，这就导致同样的功能对应的sql语句确并不相同，
    /// 所以通过不同的suer类,在里面制造出不同的sql，用于不同的数据库来调用
    /// </summary>
    class SqlServerUserHelper:IUserHelper
    {
        public User GetUser(int id)
        {
            Console.WriteLine("使用Sql Server从数据库User表中根据用户ID获取用户的实体");
            return new User();
        }

        public void Inser(User user)
        {
            Console.WriteLine("使用Sql Server向数据库User表中插入了一条User信息");
        }
        
    }
}
