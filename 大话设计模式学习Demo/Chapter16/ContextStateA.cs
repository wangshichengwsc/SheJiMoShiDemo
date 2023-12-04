using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
    /// <summary>
    /// 状态类型A
    /// </summary>
    public class ContextStateA : State
    {
        /// <summary>
        /// 根据状态的条件,动态设置实际操作类型的要操作的类型
        /// </summary>
        /// <param name="context"></param>
        public override void Handler(Context context)
        {
            if (context.Type==1)
            {
                Console.WriteLine("这是第一种状态的啦。");
            }
            else
            {
                context.state = new ContextStateB();
                context.Request();//出发对下一个类型的请求
            }
        }
    }
}
