using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_1
{
    /// <summary>
    /// 获取数据表不同表的操作类的通用接口（不区分是那种数据库）
    /// </summary>
    interface IFactory
    {
        /// <summary>
        /// 创建一个user表的操作对象
        /// </summary>
        IUser CreateUser();
        /// <summary>
        /// 创建一个dept表操作对象
        /// </summary>
        IDept CreateDept();
    }
}
