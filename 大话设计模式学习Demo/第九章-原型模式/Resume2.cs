using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九章_原型模式
{

    /// <summary>
    /// 简历类
    /// 原型模式第二种情况，原型中涉及引用类型，本例中，将工作经历的数据由一个类（工作经历类）进行存储
    /// </summary>
    public class Resume2 : ICloneable
    {

        private string name;
        private string age;
        private string sex;
        
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

        public Resume2()
        { }
        /// <summary>
        /// 私有的构造方法
        /// </summary>
        /// <param name="work"></param>
        private Resume2(WorkExperience work)
        {
            this.work = work;
        }

        //工作经历类
        private  WorkExperience work;
        //设置工作经历的方法
        public void SetWorkExperience(string workDate,string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }
        //进行自我介绍
        public void IntroduceMySelf()
        {
            string myself = string.Format("{0}--{1}--{2}--{3}--{4}", name, age, sex, work.WorkDate, work.Company);
            Console.WriteLine(myself);
        }
        /// <summary>
        /// 实现接口的Clone 方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            /*
             无引用类型类克隆，直接使用当前类的MemberwiseClone即可。但是当有引用类型对象存在的时候，
             则赋值引用但不复制引用的对象（引用对象数据不会被克隆，且展示的数据以最后一次被引用时的值为准）
             所以MemberwiseClone 又被称为浅复制。这个时候需要使用深复制
             深复制：所谓深复制就是再clone的方法中，通过克隆类私有的构造函数，将引用对象传递进去，并且赋值给克隆类的引用对象字段
             这样在克隆出的类中，就有引用对象的值且修改对应的值不会影响之前克隆类对此对象操作的值
             */

            Resume2 resume = new Resume2(this.work);
            resume.name = this.name;
            resume.age = this.age;
            resume.sex = this.sex;
            return resume;
        }
    }
}
