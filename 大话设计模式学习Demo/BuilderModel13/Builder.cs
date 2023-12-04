using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderModel13
{
    /// <summary>
    /// 产品建造抽象类
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 建造产品需要的部品A
        /// </summary>
        public abstract void BuilderPartA();
        /// <summary>
        /// 建造产品需要的部品B
        /// </summary>
        public abstract void BuilderPartB();
        /// <summary>
        /// 返回产品
        /// </summary>
        /// <returns></returns>
        public abstract Product GetResult();
    }
}
