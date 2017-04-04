using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzRally
{
    public class TaskAllocation
    {
        public string Display { set; get; } = "";
        public string Color { set; get; } = "";
        public string Expedite { set; get; } = "";
        public string Ready { set; get; } = "TRUE";
        public string Actuals { set; get; } = "";
        public string Blocked { set; get; } = "FALSE";
        public string BlockedReason { set; get; } = "";
        public float Estimate { set; get; }
        public string State { set; get; } = "Defined";
        public float ToDo { set; get; }
        public string WorkProduct { set; get; }
        public string Name { set; get; }
        public string Description { set; get; } = "";
        public string Notes { set; get; } = "";
        public string Owner { set; get; }
    }
}
