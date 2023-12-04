using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter15_1
{
    class MySqlFactory : IFactory
    {
        IDept IFactory.CreateDept()
        {
            return new MySqlDept();
        }

        IUser IFactory.CreateUser()
        {
            return new MySqlUser();
        }
    }
}
