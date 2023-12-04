using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 第六章——装饰模式
/// </summary>
namespace 第六章
{
    /// <summary>
    /// 类——人
    /// </summary>
    public class Person
    {

        private string name;
        public Person() {

        }
        public Person(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 展示穿什么衣服的方法
        /// </summary>
        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}",name);
        }


    }
}
