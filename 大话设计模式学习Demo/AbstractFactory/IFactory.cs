using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 定义一个数据库操作接口，这个接口规定了一个用于创建user操作帮助类的方法
    /// </summary>
    interface IFactory
    {
        /// <summary>
        /// 创建一个user帮助类
        /// </summary>
        /// <returns></returns>
        IUserHelper CreateUserHelper();
    }
}
