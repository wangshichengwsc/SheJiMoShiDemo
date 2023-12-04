using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
    class ContextStateC : State
    {
        public override void Handler(Context context)
        {
            if (context.Type==3)
            {
                Console.WriteLine("现在是第三种状态了");
            }
            else
            {
                Console.WriteLine("你这是啥鬼状态，我找不到啦");
            }
        }
    }
}
