using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    /// <summary>
    /// 使用简单工厂模式改进抽象工厂模式的测试主入口
    /// </summary>
    public class AbstractFactoryMain
    {
        public void Main()
        {
            /*
             这里用来模拟与前台各种数据操作
             */
            User user = new User();
            //使用sqlserver操作user
            DBHelperContext dbContext = new DBHelperContext();
            IUserHelper userHelper= dbContext.CreateUserHelper();
            userHelper.Inser(user);
            userHelper.GetUser(0);
            //客户提出使用mysql数据库
            /*
             * 哦哦
             * 我们在这里貌似可以不需要修改任何代码，只需要去DBHelperContext中修改一下全局变量db的内容即可
             */
        }
    }
}
