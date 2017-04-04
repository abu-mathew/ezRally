using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzRally
{
    public class Developer
    {
        public string Name { set; get; }
        public string Email { get; set; }
        public bool IsOnshore { set; get; }
        public bool IsLead { set; get; }
        public bool IsQA { get; set; }
        public int Capacity { get; set; }
        public string PrimarySkill { get; set; }
        public float UsedCapacity { get; set; }
    }
}
