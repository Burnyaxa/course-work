using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Gun
{
    class Pistol : Gun
    {
        private const int PISTOL_COORDINATE_X_LOWER_EDGE = -1;
        private const int PISTOL_COORDINATE_X_UPPER_EDGE = 1;
        private const int PISTOL_COORDINATE_Y_LOWER_EDGE = -1;
        private const int PISTOL_COORDINATE_Y_UPPER_EDGE = 1;

        private const char PRISTOL_BULLET_DOT = 'o';


        public override void Notify(int coordinateX, int coordinateY)
        {
            Console.WriteLine("The bullet has landed on {0},{1}", coordinateX, coordinateY);
        }

        public override void ChangeDirectory(ref int coordinateX, ref int coordinateY)
        {
            Random random = new Random();
            coordinateX += random.Next(PISTOL_COORDINATE_X_LOWER_EDGE, PISTOL_COORDINATE_X_UPPER_EDGE);
            coordinateY += random.Next(PISTOL_COORDINATE_Y_LOWER_EDGE, PISTOL_COORDINATE_Y_UPPER_EDGE);
        }

        public override void ShootTarget(int coordinateX, int coordinateY, ref Target.Target target)
        {
            StringBuilder builder = new StringBuilder(target.TargetMatrix[coordinateY]);
            if (builder[coordinateX] != Target.Target.CIRCLE_SEPARATOR)
            {
                builder[coordinateX] = PRISTOL_BULLET_DOT;
            }
        }
    }
}
