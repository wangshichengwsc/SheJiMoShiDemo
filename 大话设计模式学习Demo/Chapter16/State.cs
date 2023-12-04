using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
    /// <summary>
    /// 一个用来标记控制当前状态的类
    /// 
    /// </summary>
    public abstract class State
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">当前操作对象</param>
        public abstract void Handler(Context context);
    }
}
