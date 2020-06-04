using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_work.Target;

namespace course_work.Gun
{
    /// <summary>
    /// An abstract class to implement template method shoot
    /// </summary>
    abstract class Gun
    {
        /// <summary>
        /// Template method
        /// </summary>
        /// <param name="coordinateX">Coordinate X</param>
        /// <param name="coordinateY">Coordinate Y</param>
        /// <param name="target"> Target</param>
        public void Shoot(ref int coordinateX, ref int coordinateY, ref Target.Target target)
        {
            ChangeDirectory(ref coordinateX, ref coordinateY, target);
            Notify(coordinateX, coordinateY);
            ShootTarget(coordinateX, coordinateY, ref target);        
        }

        /// <summary>
        /// Change directory according to gun's percision
        /// </summary>
        /// <param name="coordinateX">CoordinateX</param>
        /// <param name="coordinateY">Coordinate Y</param>
        /// <param name="target">Target</param>
        public abstract void ChangeDirectory(ref int coordinateX, ref int coordinateY, Target.Target target);

        /// <summary>
        /// Notify user about a shot
        /// </summary>
        /// <param name="coordinateX">CoordinateX</param>
        /// <param name="coordinateY">CoordinateY</param>
        public abstract void Notify(int coordinateX, int coordinateY);

        /// <summary>
        /// Leave a dot on the target
        /// </summary>
        /// <param name="coordinateX"></param>
        /// <param name="coordinateY"></param>
        /// <param name="target"></param>
        public abstract void ShootTarget(int coordinateX, int coordinateY, ref Target.Target target);

        protected void CorrectUnderZeroRandom(ref int coordinate)
        {
            if (coordinate < 0)
            {
                coordinate = 0;
            }
        }

        protected void CorrectUpperMaxRandom(ref int coordinate, int maxValue)
        {
            if (coordinate > maxValue)
            {
                coordinate = maxValue;
            }
        }

    }
}
