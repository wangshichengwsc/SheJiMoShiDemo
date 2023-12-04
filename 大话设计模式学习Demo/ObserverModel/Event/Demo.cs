using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverModel.Event
{
    public class Demo
    {
        public static void EventDemo()
        {
            NBAObserver nba = new NBAObserver();

            LaoBanSubject laoban = new LaoBanSubject();
            laoban.AddNotify(nba.CloseWindow);
            laoban.Notify();
        }
    }
}
