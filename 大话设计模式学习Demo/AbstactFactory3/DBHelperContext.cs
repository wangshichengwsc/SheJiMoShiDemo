using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;//反射需要引入的命名空间
using System.Configuration;

namespace AbstactFactory3
{
    /// <summary>
    /// 获取各个帮助类获取的入口类----使用反射机制
    /// </summary>
    public class DBHelperContext
    {
        string db = "Sqlserver";//标识使用那种数据库的的全局变量，如果需要替换使用的数据，我们只需要修改这里的标识和增加对应的helper即可
        //获取user帮助类的方法
        public IUserHelper CreateUserHelper()
        {
            IUserHelper userHelper = null;
            try
            {
                string assemblyString = "AbstactFactory3";//程序集名称
                //string typeName = "AbstactFactory3.SqlServerUserHelper";//指定的类名称（最好使用命名空间+类名的形式）,有严格的大小写约束
                string typeName = "AbstactFactory3.MySqlUserHelper";//指定的类名称（最好使用命名空间+类名的形式）,有严格的大小写约束
                userHelper = (IUserHelper)Assembly.Load(assemblyString).CreateInstance(typeName);
            }
            catch (Exception ex)
            {
                //这里最好有异常记录及异常处理，不要直接抛出错误
            }
            return userHelper;
        }

        /// <summary>
        /// 以配置的方式定义需要使用的类
        /// </summary>
        /// <returns></returns>
        public IUserHelper CreateUserHelper2()
        {
            IUserHelper userHelper = null;
            try
            {
                string assemblyString = "AbstactFactory3";//程序集名称
                string typeName = ConfigurationManager.AppSettings["UserHelper"];
                userHelper = (IUserHelper)Assembly.Load(assemblyString).CreateInstance(typeName);
            }
            catch (Exception ex)
            {
                //这里最好有异常记录及异常处理，不要直接抛出错误
            }
            return userHelper;
        }

        /*
         * 分析：使用反射+抽象工厂与及简单工厂+抽象的优点
         * 
         */



    }
}
