using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAplMain.第一章
{
    public class OperateFactory
    {
        /// <summary>
        /// 根据不同的运算符返回不同的运算对象
        /// </summary>
        /// <param name="operate">运算符</param>
        /// <returns></returns>
        public static Operate creareOperate(string operateChar)
        {
            Operate operate = new Operate();
            switch (operateChar)
            {
                case "+":
                    operate = new OperationAdd();
                    break;
                case "-":
                    operate = new OperateSub();
                    break;
                case "*":
                    operate = new OperateMul();
                    break;
                case "/":
                    operate = new OperateDiv();
                    break;
                default:
                    break;
            }
            return operate;
        }
    }
}
