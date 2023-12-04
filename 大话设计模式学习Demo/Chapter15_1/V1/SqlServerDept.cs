using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_1
{
    public class SqlServerDept : IDept
    {
        void IDept.InsertDept()
        {
            Console.WriteLine("sqlserver数据库dept表插入一条数据");
        }

        void IDept.UpdateDept()
        {
            Console.WriteLine("sqlserver数据库dept表修改数据");
        }
    }
}
