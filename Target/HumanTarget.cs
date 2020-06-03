using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Target
{
    class HumanTarget : ITarget
    {
        public string[] GetTarget()
        {
            string[] target = new string[]
            {
            @"             .#####.             ",
            @"             |_____|             ",
            @"            (\#/ \#/)            ",
            @"             |  U  |             ",
            @"             |  _  |             ",
            @"             |_____|             ",
            @"           ┌--'---'--┐           ",
            @"           |         |           ",
            @"           |    .    |           ",
            @"           |         |           ",
            @"           |         |           ",
            @"           |_________|           "
            };
            return target;
        }
    }
}
