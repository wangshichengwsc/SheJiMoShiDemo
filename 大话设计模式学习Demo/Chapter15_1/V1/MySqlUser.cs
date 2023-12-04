using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter15_1
{
    /// <summary>
    /// MYsql数据库中user表的操作方法
    /// </summary>
    class MySqlUser : IUser
    {
        void IUser.InsertUser()
        {
            Console.WriteLine("mysql数据库中user表插入一条数据");
        }

        void IUser.UpdateUser()
        {
            Console.WriteLine("mysql数据库中user表修改一条数据");
        }
    }
}
