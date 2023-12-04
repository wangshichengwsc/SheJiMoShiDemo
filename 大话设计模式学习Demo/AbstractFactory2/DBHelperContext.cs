using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    /// <summary>
    /// 获取各个帮助类获取的入口类
    /// </summary>
    public class DBHelperContext
    {
        string db = "Sqlserver";//标识使用那种数据库的的全局变量，如果需要替换使用的数据，我们只需要修改这里的标识和增加对应的helper即可
        //获取user帮助类的方法
        public IUserHelper CreateUserHelper()
        {
            IUserHelper userHelper=null;
            switch (db)
            {
                case "Sqlserver":
                    userHelper = new SqlServerUserHelper();
                    break;
                case "Mysql":
                    userHelper = new MySqlUserHelper();
                    break;
            }
            return userHelper;
        }

        /*
         * 分析：使用简单工厂加工抽象工厂的优势
         * 1.如果客户要求替换操作的数据库，我们只需要在这个入口类中修改标志变量，在每个方法增加对应case分支，增加对应的帮助类即可
         * 我们前台与数据库交互的位置，是不需要修改任何代码的。
         * 2.如果现在新增加了一个操作类，我们只需要在入口出增加对应的方法和增加对应帮助类即可，需要创建/操作过多的类
         * 
         *美中不足（接着挑刺）：
         * 虽然使用了简单工厂提炼了之后，我们的修改量比以前少了很多，但是在替换了数据库后要在每个方法中增加case分支，这个操作过于重复，不是很友好
         */
    }
}
