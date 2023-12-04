using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章
{
    /// <summary>
    /// 计算价格的类
    /// </summary>
    public class StrategyContext
    {

        Strategy strategy = null;

        public StrategyContext(string type)
        {
            switch (type)
            {
                case "常规":
                    strategy = new ConcreteStrategyA();
                    break;
                case "打8折":
                    strategy = new ConcreteStrategyB();
                    break;
                case "满300减100":
                    strategy = new ConcreteStrategyC();
                    break;
                default:
                    break;
            }
        }

        public  double jisuan(double money)
        {
            double result = strategy.Algorithmlnterface(money);
           
            return result;
        }
    }
}
