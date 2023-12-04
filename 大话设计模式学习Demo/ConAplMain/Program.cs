using ConAplMain.第一章;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 第六章;
using 第九章_原型模式;
using 第十章_模板方法模式;
using FacadeModel12;
using BuilderModel13;
using AbstractFactory;
using AbstactFactory3;

/// <summary>
/// 大话设计模式章节学习
/// </summary>
namespace ConAplMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //paper();
            //FacadeModelTest();//外观模式案例
            //BuilderModelTest();//建造者模式
            //抽象工厂demo1
            //AbstractFactoryMain AbsMain = new AbstractFactoryMain();
            //AbsMain.main();
            //反射+抽象工厂
            AbstractFactory3Main absMain3 = new AbstractFactory3Main();
            //absMain3.main();
            absMain3.main2();
        }

        //实现一个计算器功能
        public static void jisuanqi()
        {
            Console.Write("输入第一个数：");
            string numberA= Console.ReadLine();
            Console.Write("请输入运算符：");
            string operateChar = Console.ReadLine();
            Console.Write("请输入第二个数：");
            string numberB = Console.ReadLine();
            double a = Convert.ToDouble(numberA);
            double b = Convert.ToDouble(numberB);
            Operate opt= OperateFactory.creareOperate(operateChar);
            opt.numberA = a;
            opt.numberB = b;
            Console.WriteLine(opt.GetResult());
        }

        //装饰模式案例
        public static void zhaungshi()
        {
            Person p = new Person("李宁");//实例化一个人——李宁

            TShirts a = new TShirts();//T恤服饰
            BigTrouser b = new BigTrouser();//垮裤服饰
            Finery f = new Finery();
            f.Decorate(p);
            a.Decorate(f);
            b.Decorate(a);

            b.Show();
        }

        //原型模式-案例1（不涉及引用类型）
        public static void yuanxing1()
        {
            //第一个简历对象-原型
            Resume resume = new Resume();
            resume.Name = "张三";
            resume.Age = "18";
            resume.Sex = "男";
            resume.setWorkExperience("2020-01-01", "TBK");
            resume.IntroduceMySelf();

            Resume resume2 = (Resume)resume.Clone();//将第一个简历克隆出来，只要修改部分内容即可有一份新的简历
            //假设第二份简历只有姓名和简历1不同，其它属性都相同
            resume2.Name = "李四";//在这里只需要修改name就可以了，不用再对其他属性赋值（已经从第一个简历里克隆出来了）
            resume2.IntroduceMySelf();
            //如果不使用克隆则下面这些属性还要再进行赋值，且resume2需要重新new一个，每重新实例化一个对象都有效率上的损耗（因为需要执行构造函数里的方法）
            //Resume resume2 = new Resume();
            //resume.Name = "李四";
            //resume.Age = "18";
            //resume.Sex = "男";
            //resume.setWorkExperience("2020-01-01", "TBK");

        }
        //原型模式-案例2（设计引用类型）
        public static void yaunxing2()
        {
            //第一个简历对象-原型
            Resume resume = new Resume();
            resume.Name = "张三";
            resume.Age = "18";
            resume.Sex = "男";
            resume.setWorkExperience("2020-01-01", "TBK");
            resume.IntroduceMySelf();

            Resume resume2 = (Resume)resume.Clone();//将第一个简历克隆出来，只要修改部分内容即可有一份新的简历
            //假设第二份简历只有工作经历和简历1不同，其它属性都相同
            resume2.setWorkExperience("2022-01-01","易正");
            resume2.IntroduceMySelf();
        }
        //模板方法模式
        public static void paper()
        {
            //实例化考生A的答卷
            TestPaper questionA = new TestQuestionA();
            questionA.test1();
            questionA.test2();
            //实例化考生B的答卷
            TestPaper questionB = new TestQuestionB();
            questionB.test1();
            questionB.test2();
          
        }
        /// <summary>
        /// 外观模式使用案例---第12张
        /// </summary>
        public static void FacadeModelTest()
        {
            /*
             模拟用户需要获取一个数据库链接字符串，并且在日志中增加一条日志记录自己获取过字符串
             */

            /*使用外观模式*/
            //FacadeClass facade = new FacadeClass();//外观模式用户主入口类
            //string conStr = facade.GetSQLConnectionString();//用户通过主入口的方法获取数据库链接字符串
            //Console.WriteLine("使用外观模式我获取到了一个链接字符串："+conStr);
            //facade.SetLogInfo("我要记录一下，我使用外观模式添加了一条日志记录");

            /*不使用外观模式*/
            //string str= DBHelper.DBConnectionStr();//直接调用数据库操作类获取数据库链接字符串
            //Console.WriteLine("我调用数据库操作类获取到了数据库链接字符串："+str);
            //MsgLog.SetMsg("不通过外观模式添加一条日志记录");   //不通过外观模式添加一条日志记录

            /*
             * 【使用外观模式和不使用外观模式的不同分析：】
             * 使用外观模式，用户只接触到一个类【FacadeClass】 
             * 不使用外观模式用户接触到了两个类【DBHelper】和【MsgLog】 增加了耦合。
             * 
             * 【什么时候使用外观模式】
             * 1.在设计初期，应该要有意识的将不同的两个层分离。
             * 2.在项目开发过程中，子系统往往因为不断的重构演化而变得复杂，大多数的模式使用会产生很多很小的类，这本是好事
             * 但是给外部调用的用户带来了使用上的困难，增加外观Facade可以提供一个非常简单的接口，减少他们之间的依赖
             * 3.维护一个遗留的大型系统的时候可能这个系统已经非常难以维护和扩展，但因为它包含非常重要的功能，新的需求开发
             * 必须要依赖于它。此时使用外观模式Facade是非常合适的。我们可以为新系统增加一个外观Facade类，来提供设计粗糙或者
             * 高度复杂的遗留代码的比较清晰，简单的接口，让新系统于Facade对象交互，Facade与遗留代码交互所有复杂的工作。
             * 
             */
        }
        /// <summary>
        /// 建造模式使用案例--第13张
        /// </summary>
        public static void BuilderModelTest()
        {
            //用户决定要建造产品1号
            ConcreteBuilder builder1 = new ConcreteBuilder();
            //告诉指挥者我需要产品1号
            Director director = new Director();
            director.Construct(builder1);//建造者进行建造
            Product prduct1= builder1.GetResult();//获取产品1号经过建造后的产品
            prduct1.Show();//展示建造出的产品
        }

    }
}
