using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverModel.Event
{
    public class LaoBanSubject : ISubject
    {
        public delegate void NotifyDelg();

        private event NotifyDelg NotifyEvent;
        NBAObserver nbaObserver = new NBAObserver();

        public void AddNotify(NotifyDelg delg)
        {
            NotifyEvent += delg;
        }
        
        public void Notify()
        {
            NotifyEvent();
        }
    }
}
