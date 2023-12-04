using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十章_模板方法模式
{
    /// <summary>
    /// 试题类
    /// 规定定了试卷试题和回答答案的方法的的抽象类
    /// 模板方法模式  核心就是借助封装，继承，多态  解决了考试这种类似的骨架相同但是具体的答案会有不同的现象
    /// 封装：将相同的骨架封装在一个类中
    /// 继承：通过不同的实现对象来继承类，达到不同的人在骨架中填充东西的操作
    /// 多态：将在骨架下不同的答案，封装成抽象方法以达到不同继承类回答不同的答案
    /// </summary>
    public abstract class TestPaper
    {
        //题目1
        public void test1()
        {
            Console.WriteLine("【题目1】1+1=?  答案：A:0 B:1 C:2 D:3");
            Console.WriteLine(string.Format("我的答案是：{0}",answer1()));
        }
        //题目2
        public void test2()
        {
            Console.WriteLine("【题目2】你是男的女的？  答案：A:男 B:女");
            Console.WriteLine(string.Format("我的答案是：{0}", answer2()));
        }

        public void test3()
        {
            Console.WriteLine("父类特有的方法");
        }

        //答案1
        public abstract string answer1();
        //答案2
        public abstract string answer2();

    }
}
