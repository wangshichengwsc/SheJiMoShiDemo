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
    /// T恤类（具体的服饰类）继承服饰类
    /// </summary>
    public class TShirts:Finery 
    {
        /// <summary>
        /// 重写父类的方法——父类Finery继承的父类Person的虚方法
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("T恤");
            base.Show();//执行继承的父类（Finery）的show方法
        }
    }
}
