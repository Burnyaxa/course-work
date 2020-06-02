using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_work.Target;

namespace course_work.ScoreCpunter
{
    interface ICounter
    {
        float GetScore(int coordinateX, int coordinateY, Target.Target target);
    }
}
