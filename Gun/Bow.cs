using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_work.Target;

namespace course_work.Gun
{
    class Bow : Gun
    {
        private const int BOW_COORDINATE_X_LOWER_EDGE = -2;
        private const int BOW_COORDINATE_X_UPPER_EDGE = 2;
        private const int BOW_COORDINATE_Y_LOWER_EDGE = -3;
        private const int BOW_COORDINATE_Y_UPPER_EDGE = 3;

        private const char BOW_ARROW_DOT = 'x';
        public override void Notify(int coordinateX, int coordinateY)
        {
            Console.WriteLine("The arrow has landed on {0},{1}", coordinateX, coordinateY);
        }

        public override void ChangeDirectory(ref int coordinateX, ref int coordinateY)
        {
            Random random = new Random();
            coordinateX += random.Next(BOW_COORDINATE_X_LOWER_EDGE, BOW_COORDINATE_X_UPPER_EDGE);
            coordinateY += random.Next(BOW_COORDINATE_Y_LOWER_EDGE, BOW_COORDINATE_Y_UPPER_EDGE);
        }

        public override void ShootTarget(int coordinateX, int coordinateY, ref Target.Target target)
        {
            StringBuilder builder = new StringBuilder(target.TargetMatrix[coordinateY]);
            if (builder[coordinateX] != Target.Target.CIRCLE_SEPARATOR)
            {
                builder[coordinateX] = BOW_ARROW_DOT;
            }
            target.TargetMatrix[coordinateY] = builder.ToString();
        }
    }
}
