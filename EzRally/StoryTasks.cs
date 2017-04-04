using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzRally
{
    public class StoryTasks
    {
        public string TaskName { set; get; }
        public int Percentage { get; set; }
        public bool OnshoreOnly { get; set; } = false;
        public bool LeadsOnly { get; set; } = false;
        public bool QAOnly { get; set; } = false;
    }
}
