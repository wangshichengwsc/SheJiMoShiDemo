using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderModel13
{
    /// <summary>
    /// 建造一个具体的产品，产品1号：型号为X的部品A，型号为Y的部品B
    /// </summary>
    public class ConcreteBuilder : Builder
    {
        private Product product = new Product();
        /// <summary>
        /// 产品的必须件--部品A
        /// </summary>
        public override void BuilderPartA()
        {
            product.Add("X");///型号为X的部品A
        }
        /// <summary>
        /// 产品的必须件--部品B
        /// </summary>
        public override void BuilderPartB()
        {
            product.Add("Y");///型号为Y的部品B
        }

        /// <summary>
        /// 根据客户要建造后的产品
        /// </summary>
        /// <returns></returns>
        public override Product GetResult()
        {
            return product;
        }
    }
}
