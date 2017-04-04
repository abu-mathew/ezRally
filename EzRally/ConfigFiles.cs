using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzRally
{
    public class ConfigFiles
    {
        public string TeamConfigFile { get; set; }
        //public string StoryPointConfigFile { get; set; }
        public string TaskConfigFile { get; set; }
        public string StoryConfigFile { get; set; }
        public string OutputFile { get; set; }
        public bool ValidConfiguration { get; set; }
    }
}
