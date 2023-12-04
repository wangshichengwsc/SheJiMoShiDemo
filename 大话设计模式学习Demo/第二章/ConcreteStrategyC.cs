using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章
{
    /// <summary>
    /// 价格计算策略3——满300减100
    /// </summary>
    public class ConcreteStrategyC : Strategy
    {
        public override double Algorithmlnterface(double money)
        {
            double result = money - Math.Floor(money / 300) * 100;
            return result;
        }
    }
}
