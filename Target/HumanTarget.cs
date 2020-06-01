using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Target
{
    class HumanTarget : ITarget
    {
        public string[] GetTarget()
        {
            string[] target = new string[]
            {
            @"1            .#####.       ",
            @"2            |_____|       ",
            @"3           (\#/ \#/)      ",
            @"4            |  U  |       ",
            @"5            \  _  /       ",
            @"6             \___/        ",
            @"7         .---'   `---.    ",
            @"8        /  #########  \   ",
            @"9       /  |####|####|  \  ",
            @"10     /  /\ ####### /\  \ ",
            @"11    (  \  \  ###  /  /  )",
            @"12     \  \  \_###_/  /  / ",
            @"13      \  \ |\   /| /  /  ",
            @"14       'uuu| \_/ |uuu'   ",
            @"15           |  |  |       ",
            @"16           |  |  |       ",
            @"17           |  |  |       ",
            @"18           |  |  |       ",
            @"19           |  |  |       ",
            @"20           )  | (        ",
            @"21         .oooO Oooo.     "
            };
            return target;
        }
    }
}
