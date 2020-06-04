using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.ScoreCounter
{
    /// <summary>
    /// Class to manipulate with score
    /// </summary>
    class ScoreCounter
    {
        public float Score { get; private set; }
        public float TotalScore { get; private set; }
        public int Shots { get; private set; }
        public ICounter Counter { private get; set; }

        public void GetScore(int coordinateX, int coordinateY, Target.Target target)
        {
            Score = Counter.GetScore(coordinateX, coordinateY, target);
        }

        /// <summary>
        /// Strategy constructor
        /// </summary>
        /// <param name="counter"></param>
        public ScoreCounter(ICounter counter)
        {
            Counter = counter;
            TotalScore = 0;
            Shots = 0;
        }

        public void SumScore()
        {
            TotalScore += Score;
        }

        public void Reset()
        {
            Score = 0;
            Shots = 0;
        }

        public void IncreaseShotsCounter()
        {
            Shots++;
        }
    }
}
