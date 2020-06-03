using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Shooter
{
    class Shooter
    {
        private static Shooter instance;
        public string Name { get; private set; }
        protected Shooter(string name)
        {
            Name = name;
        }

        public static Shooter GetInstance(string name)
        {
            if (instance == null)
            {
                instance = new Shooter(name);
            }
            return instance;
        }

        public void ResetInstance()
        {
            instance = null;
        }

    }
}
