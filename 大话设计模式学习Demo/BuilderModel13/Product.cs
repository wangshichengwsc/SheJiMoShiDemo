using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderModel13
{
    /// <summary>
    /// 产品类
    /// </summary>
    public class Product
    {
        List<string> parts = new List<string>();//制造这个产品需要的部件集合
        /// <summary>
        /// 添加一个部件的方法
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            parts.Add(part);
        }
        /// <summary>
        /// 展示这个产品给用户的方法
        /// </summary>
        public void Show()
        {
            Console.WriteLine("------创建产品-----");
            foreach (string item in parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
