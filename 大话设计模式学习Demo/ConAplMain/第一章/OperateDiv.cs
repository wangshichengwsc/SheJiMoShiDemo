using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplMain.第一章
{
    /// <summary>
    /// 执行除法
    /// </summary>
    public class OperateDiv:Operate
    {

        /// <summary>
        /// 重写计算方法
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = numberA / numberB;
            return result;
        }
    }
}
