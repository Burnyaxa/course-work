using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_work.Target;

namespace course_work.ScoreCounter
{
    class HumanTargetScoreCounter : ICounter
    {
        private const int BODY_LEFT_X = 11;
        private const int BODY_LOWER_Y = 6;

        private const int BODY_RIGHT_X = 21;
        private const int BODY_UPPER_Y = 11;

        private const int HEAD_LEFT_X = 13;
        private const int HEAD_LOWER_Y = 0;

        private const int HEAD_RIGHT_X = 19;
        private const int HEAD_UPPER_Y = 5;

        private const int HEAD_CENTER_Y = 3;
        private const int HEAD_CENTER_X = 16;

        private const int HEAD_SCORE_CENTER = 20;
        private const int HEAD_SCORE_MISS = 10;

        private const int BODY_CENTER_Y = 8;
        private const int BODY_CENTER_X = 16;

        private const int BODY_SCORE_CENTER = 10;
        private const int BODY_SCORE_MISS = 5;

        public float GetScore(int coordinateX, int coordinateY, Target.Target target)
        {
            if(isInHead(coordinateX, coordinateY))
            {
                if(coordinateX == HEAD_CENTER_X && coordinateY == HEAD_CENTER_Y)
                {
                    return HEAD_SCORE_CENTER;
                }
                else
                {
                    return HEAD_SCORE_MISS;
                }
            }
            if (isInBody(coordinateX, coordinateY))
            {
                if (coordinateX == BODY_CENTER_X && coordinateY == BODY_CENTER_Y)
                {
                    return BODY_SCORE_CENTER;
                }
                else
                {
                    return BODY_SCORE_MISS;
                }

            }
            return 0;
        }

        private bool isInHead(int coordinateX, int coordinateY)
        {
            if ((coordinateX > HEAD_LEFT_X && coordinateX < HEAD_RIGHT_X) && (coordinateY > HEAD_LOWER_Y && coordinateY < HEAD_UPPER_Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isInBody(int coordinateX, int coordinateY) 
        {
            if ((coordinateX > BODY_LEFT_X && coordinateX < BODY_RIGHT_X) && (coordinateY > BODY_LOWER_Y && coordinateY < BODY_UPPER_Y))
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
