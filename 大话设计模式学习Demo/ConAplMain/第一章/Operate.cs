using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplMain.第一章
{
    /// <summary>
    /// 运算类
    /// </summary>
    public class Operate
    {
        public double numberA { get; set; }
        public double numberB { get; set; }
        /// <summary>
        /// 一个虚方法——用于返回计算结果
        /// </summary>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
