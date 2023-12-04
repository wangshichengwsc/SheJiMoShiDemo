using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
    class ContextStateB : State
    {
        public override void Handler(Context context)
        {
            if (context.Type==2)
            {
                //context.state =new ContextStateB();
                //这要的不是赋值要的是符合这个状态需要做的逻辑
                Console.WriteLine("这是第二种状态了啦");
            }
            else
            {
                context.state = new ContextStateC();
                context.Request();
            }
        }
    }
}
