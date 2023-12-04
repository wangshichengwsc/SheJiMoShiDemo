using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    ///  抽象工厂 案例效果调用主入口
    /// </summary>
    public class AbstractFactoryMain
    {
        public void main()
        {
            User user = new User();


            //第一次开发我使用的是sqlserver数据库操作user数据
            //IFactory factory = new SqlServerFactory();
            ////获取user帮助类/接口
            //IUserHelper userHelper = factory.CreateUserHelper();
            ////创建用户
            //userHelper.Inser(user);
            ////获取用户信息
            //userHelper.GetUser(0);


            //接下来用户改变需求，需要使用mysql数据库
            IFactory factory = new MySqlFactory();
            IUserHelper userHelper=factory.CreateUserHelper();
            userHelper.Inser(user);
            userHelper.GetUser(0);


            /*
             * 综合对比上面使用sqlserver数据库和使用mysql数据库的代码
             * 我们可以发现，使用这样的模式，如果用户操作的数据库发生了变化，我只需要增加对应数据库操作类，user帮助类 继承相对应的接口
             * 我们只需要修改实例化数据库操作类的时候修改一下对应的数据库操作类对象即可。不需要去修改其它的类与代码，减少了对原有代码的修改。
             * 而且如果有一天用户突然需要恢复使用sqlserver的时候，我们只需要修改少量的代码即可实现数据库转换
             * 
             * 但这种模式也有弊端：
             * 1.我现在只有一个user类需要进行数据访问操作，但实际中我们会有很多类需要进行数据访问操作
             * 这样一来虽然增加新的数据库，我们不需要对过多的现有代码做修改，但是我们缺需要为每个类添加
             * 对应的数据库操作类，和帮助类。比如我们有10个类要对数据库访问，那么替换数据库后我们需要增加
             * 10个继承对应user帮助类接口的帮助类和一个继承了数据库操作接口的新的数据操作类，并在里面实例化对应的帮助类
             * 2.虽然我们对原有代码的修改很少，但是只要替换了数据库，我们就需要去所有的使用了数据库操作类的地方去修改对应的实例对象
             * 这在一个大型项目中，修改的代码相对来说也是很多的。
             * 3.如果我们现在增加一个**类，我们需要增加 I**Helper接口，**Helper类，对应IFactory 需要增加创建对应帮助类的方法，对应所以的继承了IFactory接口
             * 的类都需要增加对这个方法的实现。（如果我们同时保留了sqlserver和mysql的那么我们就需要修改两个类）
             */
        }
    }
}
