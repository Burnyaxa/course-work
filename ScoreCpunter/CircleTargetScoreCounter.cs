using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.ScoreCpunter
{
    class CircleTargetScoreCounter : ICounter
    {
        private const int CENTRE_COORDINATE_X = 11;
        private const int CENTRE_COORDINATE_Y = 28;

        private const int STARTING_POSITION_Y = 1;
        private const int ENDING_POSITION_Y = 21;

        private const char CIRCLE_SEPARATOR = '#';

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

            string targetY = target.TargetMatrix[coordinateY - 1];
            string leftPart = targetY.Substring(0, coordinateX - 1);
            string rightPart = targetY.Substring(coordinateX - 1);

            if (leftPart.IndexOf(CIRCLE_SEPARATOR) != -1 && rightPart.IndexOf(CIRCLE_SEPARATOR) != -1)
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
