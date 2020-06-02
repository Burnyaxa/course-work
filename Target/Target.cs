using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Target
{
    class Target
    {
        public string[] TargetMatrix{ get; private set; }
        public ITarget ITarget { private get; set; }

        public Target(ITarget target)
        {
            ITarget = target;
        }

        public void GetTarget()
        {
            TargetMatrix = ITarget.GetTarget();
        }

    }
}
