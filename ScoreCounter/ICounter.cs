using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_work.Target;

namespace course_work.ScoreCounter
{
    /// <summary>
    /// Strategy interface
    /// </summary>
    interface ICounter
    {
        /// <summary>
        /// Count score
        /// </summary>
        /// <param name="coordinateX"></param>
        /// <param name="coordinateY"></param>
        /// <param name="target"></param>
        /// <returns>Score</returns>
        float GetScore(int coordinateX, int coordinateY, Target.Target target);
    }
}
