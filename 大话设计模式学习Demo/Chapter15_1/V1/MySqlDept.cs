using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter15_1
{
    /// <summary>
    /// mysql数据库中dept表的操作类
    /// </summary>
    class MySqlDept : IDept
    {
        void IDept.InsertDept()
        {
            Console.WriteLine("mysql数据库中dept表插入一条数据");
        }

        void IDept.UpdateDept()
        {
            Console.WriteLine("mysql数据库中dept表修改一条数据");
        }
    }
}
