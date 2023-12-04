using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplMain.第一章
{
    /// <summary>
    /// 执行减法运算
    /// </summary>
    public class OperateSub:Operate
    {
        public override double GetResult()
        {
            double result = numberA - numberB;
            return result;
        }
    }
}
