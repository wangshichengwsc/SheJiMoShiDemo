using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 服饰类
    /// </summary>
    public class Finery:Person
    {
        public Person _perosn;

        public void Decorator(Person person)
        {
            this._perosn = person;
        }

        public override void Show()
        {
            if (_perosn!=null)
            {
                _perosn.Show();
            }
        }
    }
}
