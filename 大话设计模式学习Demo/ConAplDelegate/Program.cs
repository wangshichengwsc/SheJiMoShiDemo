using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //DelegateTest();
            DelegateTest2();
        }

        /// <summary>
        /// 关于适用委托的一个案例
        /// </summary>
        public static void DelegateTest()
        {
            Cat cat = new Cat("Tom");//实例化一个猫类——Tom
            Mouse mouse1 = new Mouse("Jerry");//实例化一个老鼠
            Mouse mouse2 = new Mouse("Jack");//实例化一个老鼠

            cat.CatShout += new Cat.CatShoutEventHandler(mouse1.Run);//表示经Mouse的Run方法通过实例化委托Cat.CatShoutEventHandler 登记到cat的事件CatShou当中
            cat.CatShout += new Cat.CatShoutEventHandler(mouse2.Run);

            //执行猫说话的方法
            cat.Shout();
            Console.Read();
        }

        public static void DelegateTest2()
        {
            Cat cat = new Cat("Tom");//实例化一个猫类——Tom
            Mouse mouse1 = new Mouse("Jerry");//实例化一个老鼠
            Mouse mouse2 = new Mouse("Jack");//实例化一个老鼠

            cat.CatShoutAgs += new Cat.CatShoutEventAgsHandler(mouse1.Run2);
            cat.CatShoutAgs += new Cat.CatShoutEventAgsHandler(mouse2.Run2);

            //执行猫说话的方法
            cat.Shout2();
            Console.Read();
        }
    }
}
