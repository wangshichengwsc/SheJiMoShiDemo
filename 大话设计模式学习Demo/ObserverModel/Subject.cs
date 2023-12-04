using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverModel
{
    /// <summary>
    /// 通知者抽象类
    /// </summary>
    public abstract class Subject
    {
        /// <summary>
        /// 通知者要通知的观察者集合
        /// </summary>
        private List<Observer> obserberList = new List<Observer>();
        /// <summary>
        /// 添加一个观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer) {
            obserberList.Add(observer);
        }
        /// <summary>
        /// 移除一个观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer) {
            obserberList.Remove(observer);
        }
        /// <summary>
        /// 通知观察者的方法
        /// </summary>
        public void Notify() {

            foreach (Observer item in obserberList)
            {
                item.Update();//调用观察者的接受通知的消息
            }
        }
    }
}
