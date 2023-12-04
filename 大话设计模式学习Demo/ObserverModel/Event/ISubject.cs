using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverModel.Event
{
    /// <summary>
    /// 通知者
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 通知观察者
        /// </summary>
        void Notify();
    }
}
