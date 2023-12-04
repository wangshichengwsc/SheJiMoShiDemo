using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二章
{
    /// <summary>
    /// 计算价格的抽象类
    /// </summary>
    public abstract class Strategy
    {
        public abstract double Algorithmlnterface(double money);
    }
}
