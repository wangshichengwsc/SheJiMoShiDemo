using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_模板方法模式
{
    /// <summary>
    /// 考生B的答卷
    /// </summary>
    public class TestQuestionB : TestPaper
    {
        public override string answer1()
        {
            return "C";
        }

        public override string answer2()
        {
            return "B";
        }

        public void funA()
        {
            Console.WriteLine("这是子类特有的方法");
        }
    }
}
