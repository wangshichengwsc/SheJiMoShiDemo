using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_1
{
    /// <summary>
    /// user表 数据库操作方法接口类
    /// </summary>
    public interface IUser
    {
        void InsertUser();
        void UpdateUser();
    }
}
