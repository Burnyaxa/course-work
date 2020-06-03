using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.ScoreCpunter
{
    class CircleTargetScoreCounter : ICounter
    {
        private const int CENTRE_COORDINATE_X = 27;
        private const int CENTRE_COORDINATE_Y = 10;

        private const int STARTING_POSITION_Y = 0;
        private const int ENDING_POSITION_Y = 20;

        private const float BEST_RESULT = 100; 

        public float GetScore(int coordinateX, int coordinateY, Target.Target target)
        {
            if(isInCircle(coordinateX, coordinateY, target))
            {
                float distance = (float)Math.Sqrt(Math.Pow(coordinateX - CENTRE_COORDINATE_X, 2) + Math.Pow(coordinateY - CENTRE_COORDINATE_Y, 2));
                float resultScore = BEST_RESULT - distance;
                return resultScore;
            }
            else
            {
                return 0;
            }

            
        }

        private bool isInCircle(int coordinateX, int coordinateY, Target.Target target)
        {
            if(coordinateY == STARTING_POSITION_Y || coordinateY == ENDING_POSITION_Y)
            {
                return false;
            }

            string targetY = target.TargetMatrix[coordinateY];
            string leftPart = targetY.Substring(0, coordinateX);
            string rightPart = targetY.Substring(coordinateX);

            if (leftPart.IndexOf(Target.Target.CIRCLE_SEPARATOR) != -1 && rightPart.IndexOf(Target.Target.CIRCLE_SEPARATOR) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
