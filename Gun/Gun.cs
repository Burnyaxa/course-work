using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_work.Target;

namespace course_work.Gun
{
    abstract class Gun
    {
        public void Shoot(ref int coordinateX, ref int coordinateY, ref Target.Target target)
        {
            ChangeDirectory(ref coordinateX, ref coordinateY, target);
            Notify(coordinateX, coordinateY);
            ShootTarget(coordinateX, coordinateY, ref target);        
        }

        public abstract void ChangeDirectory(ref int coordinateX, ref int coordinateY, Target.Target target);
        public abstract void Notify(int coordinateX, int coordinateY);
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
