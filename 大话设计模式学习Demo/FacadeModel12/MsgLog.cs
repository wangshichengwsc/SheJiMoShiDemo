using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeModel12
{
    /// <summary>
    /// 消息日志类
    /// </summary>
    public class MsgLog
    {
        public static void SetMsg(string msg)
        {
            Console.WriteLine("我这里记录了一条日志："+msg);
        }
    }
}
