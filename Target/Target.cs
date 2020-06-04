using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Target
{
    /// <summary>
    /// Contains info about targets
    /// </summary>
    class Target
    {
        public const char CIRCLE_SEPARATOR = '#';

        public const int CIRCLE_TARGET_SIZE_Y = 20;
        public const int CIRCLE_TARGET_SIZE_X = 52;

        public const int HUMAN_TARGET_SIZE_Y = 11;
        public const int HUMAN_TARGET_SIZE_X = 32;

        public string[] TargetMatrix{ get; set; }
        public ITarget ITarget { get; set; }

        /// <summary>
        /// Strategy constructor
        /// </summary>
        /// <param name="target"></param>
        public Target(ITarget target)
        {
            ITarget = target;
            TargetMatrix = ITarget.GetTarget();
        }

        public void GetTarget()
        {
            TargetMatrix = ITarget.GetTarget();
        }

    }
}
