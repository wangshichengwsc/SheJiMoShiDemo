using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九章_原型模式
{
    /// <summary>
    /// 工作经历类
    /// </summary>
    public class WorkExperience : ICloneable
    {
        private string workDate;
        private string company;
        /// <summary>
        /// 工作时间
        /// </summary>
        public string WorkDate
        {
            get
            {
                return workDate;
            }

            set
            {
                workDate = value;
            }
        }
        /// <summary>
        /// 工作公司
        /// </summary>
        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }


        /// <summary>
        /// 实现接口Clone的方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();//返回当前类的副本-克隆对象
        }
    }
}
