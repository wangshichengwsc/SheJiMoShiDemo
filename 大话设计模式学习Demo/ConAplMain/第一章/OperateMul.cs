using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplMain.第一章
{
    /// <summary>
    /// 执行乘法运算
    /// </summary>
    public class OperateMul:Operate
    {
        /// <summary>
        /// 重写运算方法
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = numberA * numberB;
            return result;
        }
    }
}
