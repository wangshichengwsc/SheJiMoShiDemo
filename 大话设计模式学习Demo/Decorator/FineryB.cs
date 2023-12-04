using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FineryB:Finery
    {
        public override void Show()
        {
            Console.WriteLine("短裤");
            base.Show();
        }
    }
}
