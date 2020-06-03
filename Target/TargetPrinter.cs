using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Target
{
    class TargetPrinter
    {
        public static void PrintTarget(Target target)
        {
            foreach(string str in target.TargetMatrix)
            {
                Console.WriteLine(str);
            }
        }
    }
}
