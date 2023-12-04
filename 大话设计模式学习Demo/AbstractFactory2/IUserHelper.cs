using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    /// <summary>
    /// 用户类接口，不管的我对user的操作是用sqlserver操作还是用mysql操作，我的user都必须有创建user和根据id获取user的方法
    /// </summary>
    public  interface IUserHelper
    {
        /// <summary>
        /// 创建user的方法
        /// </summary>
        /// <param name="user"></param>
        void Inser(User user);
        /// <summary>
        /// 获取user信息的方法
        /// </summary>
        /// <param name="id"></param>
        User GetUser(int id);  
    }
}
