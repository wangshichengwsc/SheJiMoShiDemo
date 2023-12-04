using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 使用mysql数据库数据的user帮助类
    /// </summary>
    class MySqlUserHelper : IUserHelper
    {
        public User GetUser(int id)
        {
            Console.WriteLine("使用mysql数据库在user信息表中根据id获取对应的user信息");
            return new User();
        }

        public void Inser(User user)
        {
            Console.WriteLine("使用mysql数据库在user信息表增加了一条user信息");
        }
    }
}
