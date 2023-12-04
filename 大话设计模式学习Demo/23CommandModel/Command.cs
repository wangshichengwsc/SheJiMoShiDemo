using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23CommandModel
{
    /// <summary>
    /// 命令抽象类
    /// </summary>
    public abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer receiver)
        {

        }
    }
}
