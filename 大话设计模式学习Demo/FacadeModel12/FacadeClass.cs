using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 外观模式：提供一个统一的入口，由用户访问入口里的方法，来满足用户的功能，入口里具体需要调用那些类实现，由入口来进行控制即可
/// </summary>
namespace FacadeModel12
{
    /// <summary>
    /// 外观主入口类
    /// </summary>
    public class FacadeClass
    {
        /// <summary>
        /// 提供给用户用于获取数据库配置字符串的方法
        /// </summary>
        /// <returns></returns>
        public string GetSQLConnectionString()
        {
            return DBHelper.DBConnectionStr();
        }
        /// <summary>
        /// 提供给用户用于记录日志的方法
        /// </summary>
        /// <param name="msg"></param>
        public void SetLogInfo(string msg)
        {
            MsgLog.SetMsg(msg);
        }
    }
}
