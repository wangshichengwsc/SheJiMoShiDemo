using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_模板方法模式
{
    /// <summary>
    /// 考生A的答卷
    /// </summary>
    public class TestQuestionA : TestPaper
    {
        public override string answer1()
        {
            return "A";
        }

        public override string answer2()
        {
            return "B";
        }
    }
}
