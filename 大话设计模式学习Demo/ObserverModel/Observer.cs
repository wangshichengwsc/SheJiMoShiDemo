using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 观察者模式
/// </summary>
namespace ObserverModel
{
    /// <summary>
    /// 观察者抽象类
    /// </summary>
    public abstract class Observer
    {
        /// <summary>
        /// 用于接收通知者发送的通知
        /// </summary>
        public abstract void Update();
    }
}
