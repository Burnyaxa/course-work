﻿using System;
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
            ChangeDirectory(ref coordinateX, ref coordinateY);
            Notify(coordinateX, coordinateY);
            ShootTarget(coordinateX, coordinateY, ref target);        
        }

        public abstract void ChangeDirectory(ref int coordinateX, ref int coordinateY);
        public abstract void Notify(int coordinateX, int coordinateY);
        public abstract void ShootTarget(int coordinateX, int coordinateY, ref Target.Target target);
    }
}
