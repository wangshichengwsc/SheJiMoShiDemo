using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplMain.第一章
{
    /// <summary>
    /// 执行加法运算的类
    /// </summary>
    public class OperationAdd:Operate
    {
        /// <summary>
        /// 重写GetResult方法
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = numberA + numberB;
            return result;
        }
    }
}
