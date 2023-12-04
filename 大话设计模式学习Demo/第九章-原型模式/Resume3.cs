using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九章_原型模式
{
    public class Resume3:ICloneable
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
        //工作经历类
        private WorkExperience work;
        //设置工作经历的方法
        public void SetWorkExperience(string workDate, string company)
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

        public object Clone()
        {
            Resume3 resume3 = (Resume3)this.MemberwiseClone();
            resume3.work = (WorkExperience)work.Clone();
            return (object)resume3;
        }
    }
}
