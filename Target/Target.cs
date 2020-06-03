using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Target
{
    class Target
    {
        public const char CIRCLE_SEPARATOR = '#';

        public string[] TargetMatrix{ get; set; }
        public ITarget ITarget { private get; set; }

        public Target(ITarget target)
        {
            TargetMatrix = new string[] { };
            ITarget = target;
        }

        public void GetTarget()
        {
            TargetMatrix = ITarget.GetTarget();
        }

    }
}
