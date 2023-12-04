using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 建造者模式：一个复杂的对象的创建步骤与它的表示（显示）结果不同，需要用到建造者【builder】模式
/// </summary>
namespace BuilderModel13
{
    /// <summary>
    /// 指挥者类
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 根据用户传入的需要的产品，指挥者决定怎么样建造
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuilderPartA();//先建造出部品A
            builder.BuilderPartB();//再建造出产品B
        }
    }
}
