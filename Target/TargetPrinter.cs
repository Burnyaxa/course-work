using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Target
{
    /// <summary>
    /// Class to print a target
    /// </summary>
    class TargetPrinter
    {
        /// <summary>
        /// Prints a target
        /// </summary>
        /// <param name="target"></param>
        public static void PrintTarget(Target target)
        {
            foreach(string str in target.TargetMatrix)
            {
                Console.WriteLine(str);
            }
        }
    }
}
