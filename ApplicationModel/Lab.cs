using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationModel
{
    class Lab
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ConditionToPass { get; set; }
        public int NumberOfWeeks { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
