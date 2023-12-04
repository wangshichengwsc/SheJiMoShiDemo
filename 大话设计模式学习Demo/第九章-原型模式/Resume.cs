using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九章_原型模式
{
    /// <summary>
    /// 简历类
    /// 原型模式核心通过克隆来实现
    /// 克隆：核心通过继承ICloneable接口内置的Clone方法，在clone 方法里通过调用当前类的MemberwiseClone方法，返回当前对象的副本（克隆对象）
    /// 本类是最简单的原型模式，克隆的时候，只涉及值类型不涉及引用类型
    /// </summary>
    public class Resume:ICloneable
    {
        private string name;
        private string age;
        private string sex;
        private string workdate;
        private string company;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }
        
        //设置工作经历
        public void setWorkExperience(string workDate,string company)
        {
            this.workdate = workDate;
            this.company = company;
        }

        //进行自我介绍
        public void IntroduceMySelf()
        {
            string myself = string.Format("{0}--{1}--{2}--{3}--{4}",name,age,sex,workdate,company);
            Console.WriteLine(myself);
        }
        //
        public object Clone()
        {
            return this.MemberwiseClone();//获取当前类的副本（克隆对象）
        }
    }
}
