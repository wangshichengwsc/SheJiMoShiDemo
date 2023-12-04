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
    /// 跨裤类（具体的服饰类）继承服饰类
    /// </summary>
    public class BigTrouser : Finery 
    {
        /// <summary>
        /// 重写父类的方法——父类Finery继承的父类Person的虚方法
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("跨库");
            /*之所以能动态拼装服饰，其中一个重点就是执行base.Show的方法（继承的父类的方法），
             只有这样前面累加的服饰才可以显示出来，否则就只能展示最后一个示例化的服饰类执行的show方法
             
             */
            base.Show();//执行继承的父类（Finery）的show方法
        }
    }
}
