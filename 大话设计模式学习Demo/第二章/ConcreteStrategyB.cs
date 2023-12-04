using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章
{
    /// <summary>
    /// 价格计算策略2——打八折
    /// </summary>
    public class ConcreteStrategyB : Strategy
    {
        
        public override double Algorithmlnterface(double money)
        {
            double result = money * 0.8;
            return result;
        }
    }
}
