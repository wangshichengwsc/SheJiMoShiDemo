using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_1
{
    public class SqlServerUser : IUser
    {
        void IUser.InsertUser()
        {
            Console.WriteLine("向sqlserver数据插入一条user信息");
        }

        void IUser.UpdateUser()
        {
            Console.WriteLine("修改sqlserver数据库user表的信息");
        }
    }
}
