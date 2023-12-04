using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
    /// <summary>
    /// 这是一个工作类，用来执行 不同的时间输出不同的状态
    /// </summary>
    public class Context
    {
        public int Type { get; set; }
        public State state { get; set; }

        public void Request() {
            state.Handler(this);
        }
    }
}
