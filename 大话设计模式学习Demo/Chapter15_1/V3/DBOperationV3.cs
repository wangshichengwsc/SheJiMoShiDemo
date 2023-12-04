using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Reflection;//使用反射必须引入的命名空间
using System.Configuration;


namespace Chapter15_1.V3
{
    /// <summary>
    /// 基于反射动态获取数据库操作对象
    /// </summary>
    public class DBOperation
    {
        //string namespaceStr = "Chapter15_1";
        //string dbTypeStr = "MySql";
        #region 读取配置文件中的配置信息
        string namespaceStr = ConfigurationManager.AppSettings["DBNameSpeace"];
        string dbTypeStr = ConfigurationManager.AppSettings["DBType"];
        #endregion
        public IDept CreateDept()
        {
            string className = namespaceStr + "." + dbTypeStr + "Dept";
            IDept dept = null;
            dept = (IDept)Assembly.Load(namespaceStr).CreateInstance(className);
            return dept;
        }

        public IUser CreateUser()
        {
            string className = namespaceStr + "." + dbTypeStr + "User";
            IUser user = null;
            user = (IUser)Assembly.Load(namespaceStr).CreateInstance(className);
            return user;
        }
    }
}
