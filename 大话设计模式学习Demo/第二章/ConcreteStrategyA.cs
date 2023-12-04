using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章
{
    /// <summary>
    /// 价格计算模式1——常规（原价）
    /// </summary>
    public class ConcreteStrategyA : Strategy
    {
        
        /// <summary>
        /// 重写抽象方法
        /// </summary>
        /// <returns></returns>
        public override double Algorithmlnterface(double money)
        {
            double result = money;
            return result;
        }
    }
}
