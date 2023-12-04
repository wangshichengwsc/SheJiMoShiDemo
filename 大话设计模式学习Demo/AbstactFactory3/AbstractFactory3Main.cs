using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactory3
{
    /// <summary>
    /// 反射+抽象工厂模式  测试效果入口类
    /// </summary>
    public class AbstractFactory3Main
    {
        public void main()
        {
            User user = new User();
            DBHelperContext dbContext = new DBHelperContext();
            IUserHelper userHelper= dbContext.CreateUserHelper();

            userHelper.Inser(user);
            userHelper.GetUser(0);
        }
        public void main2()
        {
            User user = new User();
            DBHelperContext dbContext = new DBHelperContext();
            IUserHelper userHelper = dbContext.CreateUserHelper2();
            userHelper.Inser(user);
            userHelper.GetUser(0);
        }
    }
}
