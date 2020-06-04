using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace course_work.Target
{
    /// <summary>
    /// Concrete strategy
    /// </summary>
    class CircleTarget : ITarget
    {
        public string[] GetTarget()
        {
            string[] target = ConfigurationManager.AppSettings["circleTarget"].Split(new char[] {','});
            //string[] target = new string[]
            //{
            //     @"                    *** ### ### ***                  ",
            //     @"                *#                   #*              ",
            //     @"            *#                           #*          ",
            //     @"         *#                                 #*       ",
            //     @"       *#                                     #*     ",
            //     @"     *#                                         #*   ",
            //     @"    *#                                           #*  ",
            //     @"   *#                                             #* ",
            //     @"  *#                                               #*",
            //     @"  *#                                               #*",
            //     @"  *#                       .                       #*",
            //     @"  *#                                               #*",
            //     @"  *#                                               #*",
            //     @"   *#                                             #* ",
            //     @"    *#                                           #*  ",
            //     @"     *#                                         #*   ",
            //     @"       *#                                     #*     ",
            //     @"         *#                                 #*       ",
            //     @"            *#                           #*          ",
            //     @"                *#                   #*              ",
            //     @"                    *** ### ### ***                  "
            //};
            return target;
            
        }
    }
}
