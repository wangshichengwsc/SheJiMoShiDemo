using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplDelegate
{
    /// <summary>
    /// 猫类
    /// </summary>
    public  class Cat
    {

        private string name;
        /// <summary>
        /// 重载构造函数
        /// </summary>
        /// <param name="name">猫的名称</param>
        public Cat(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 声明一个委托,用于实现老鼠说“老猫来了，快跑”的功能
        /// </summary>
        public delegate void CatShoutEventHandler();
        /// <summary>
        /// 一个委托——有参无返
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void CatShoutEventAgsHandler(object sender,CatShoutEventAgs e);
        /// <summary>
        /// 声明一个事件——用于在执行猫说“喵，我是TOM”的时候，通过事件记录，执行老鼠说“老猫来了，快跑”
        /// </summary>
        public event CatShoutEventHandler CatShout;
        /// <summary>
        /// 声明一个事件
        /// </summary>
        public event CatShoutEventAgsHandler CatShoutAgs;
        /// <summary>
        /// 猫说“喵，我是Tom”的方法
        /// </summary>
        public void Shout()
        {
            Console.WriteLine("喵，我是{0}",name);

            if (CatShout!=null)
            {
                CatShout();//表示当执行shout方法的时候，如果CatShout事件中有对象登记事件则执行CatShout
            }
        }
        /// <summary>
        /// 第二个猫说“喵，我是Tom”的方法
        /// </summary>
        public void Shout2()
        {
            Console.WriteLine("喵，我是{0}",name);

            if (CatShoutAgs!=null)
            {
                CatShoutEventAgs eAgs = new CatShoutEventAgs();
                eAgs.Name = this.name;
                CatShoutAgs(this,eAgs);
            }
        }
    }
}
