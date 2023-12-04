using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplDelegate
{
    /// <summary>
    /// 老鼠类
    /// </summary>
    public class Mouse
    {
        private string name;

        public Mouse(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 老鼠说“老猫来了，快跑”
        /// </summary>
        public void Run()
        {
            Console.WriteLine("老猫来了，{0}，快跑",name);
        }

        public void Run2(object sender,CatShoutEventAgs args)
        {
            Console.WriteLine("老猫{0}来了，{1}快跑",args.Name,name);
        }
    }
}
