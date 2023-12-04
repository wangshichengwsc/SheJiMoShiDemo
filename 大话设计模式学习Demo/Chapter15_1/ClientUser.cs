using Chapter15_1.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_1
{
    /// <summary>
    /// 模拟客户端（前端）执行的操作
    /// </summary>
    public class ClientUser
    {
        /// <summary>
        /// sqlserver数据库执行插入一个用户和一个部门的操作
        /// </summary>
        public void V1_Demo1()
        {
            //使用sqlserver数据库的时候
            IFactory iFactory = new SqlServerFactory();
            //获取user表操作对象
            IUser user = iFactory.CreateUser();
            //向user表插入一条数据
            user.InsertUser();
            //修改user表数据
            user.UpdateUser();
        }
        public void V1_Demo2() {
            IFactory iFactory = new MySqlFactory();
            //获取user表操作对象
            IUser user = iFactory.CreateUser();
            //向user表插入一条数据
            user.InsertUser();
            //修改user表数据
            user.UpdateUser();
        }
        public void V2_Demo1()
        {
            /*
             V2与V1相比，在用户操作层 不会明显的看到任何关于访问的数据库的信息（V1可在IFactory实例化的时候分辨出使用的是什么数据库）
             */
            DBOperation dbOpt = new DBOperation();
            IUser user= dbOpt.CreateUser();
            user.InsertUser();
            user.UpdateUser();
        }
        public void V3_Demo1() {
            /*
             V2与V1相比，在用户操作层代码完全一直，但是在DBOperation 操作类内部使用了更为灵活的方式返回不同数据库的操作类
             */
            Chapter15_1.V3.DBOperation dbOpt = new Chapter15_1.V3.DBOperation();
            IUser user = dbOpt.CreateUser();
            user.InsertUser();
            user.UpdateUser();
        }
    }
}
