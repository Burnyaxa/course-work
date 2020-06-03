using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Target
{
    class CircleTarget : ITarget
    {
        public string[] GetTarget()
        {
            string[] target = new string[]
            {
                 @"                    *** ### ### ***                  ",
                 @"                *#                   #*              ",
                 @"            *#                           #*          ",
                 @"         *#                                 #*       ",
                 @"       *#                                     #*     ",
                 @"     *#                                         #*   ",
                 @"    *#                                           #*  ", 
                 @"   *#                                             #* ",
                 @"  *#                                               #*",
                 @"  *#                                               #*",
                 @"  *#                       .                       #*",
                 @"  *#                                               #*",
                 @"  *#                                               #*",
                 @"   *#                                             #* ",
                 @"    *#                                           #*  ",
                 @"     *#                                         #*   ",
                 @"       *#                                     #*     ",
                 @"         *#                                 #*       ",     
                 @"            *#                           #*          ",
                 @"                *#                   #*              ",
                 @"                    *** ### ### ***                  "
            };
            return target;
            
        }
    }
}
