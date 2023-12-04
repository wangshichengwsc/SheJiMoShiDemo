using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章
{

    /// <summary>
    /// 服饰类，继承人（类），重写人（类）的Show方法（展示穿衣的方法）
    /// </summary>
    public  class Finery:Person
    {

        protected Person component;

        /// <summary>
        /// 经人添加到服饰类  方便执行“装饰的***人”这句话——并非必须的
        /// </summary>
        /// <param name="component"></param>
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component!=null)
            {
                component.Show();//执行父类的show方法——主要用于输入“装扮的***人”这句话
            }
        }
    }
}
