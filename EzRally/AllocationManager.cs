using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzRally
{
    public class AllocationManager
    {
        private List<TaskAllocation> allocationData;
        public List<TaskAllocation> GetAllocationData()
        {
            return allocationData;
        }
        public void SetAllocationData(List<TaskAllocation> value)
        {
            allocationData = value;
        }

        public AllocationManager()
        {
            allocationData = new List<TaskAllocation>();
        }

        public List<TaskAllocation> GenerateAllocations(List<SprintStory> CurrentSprint, List<StoryTasks> TaskListing, List<Developer> Team, int StoryPointSize)
        {
            foreach (var story in CurrentSprint)
            {
                foreach (var task in TaskListing)
                {
                    TaskAllocation newTaskAllocation = new TaskAllocation();
                    newTaskAllocation.WorkProduct = story.StoryTitle;
                    newTaskAllocation.Name = task.TaskName;
                    float taskEffort = (story.Points * StoryPointSize) * task.Percentage;
                    newTaskAllocation.Estimate = taskEffort / 100;
                    newTaskAllocation.ToDo = newTaskAllocation.Estimate;

                    if (task.OnshoreOnly == true && task.LeadsOnly == true)
                    {
                        newTaskAllocation.Owner = "Rijosh";
                    } else if (task.LeadsOnly == true && task.OnshoreOnly == false)
                    {
                        newTaskAllocation.Owner = "Amit";
                    } else if (task.QAOnly == true)
                    {
                        newTaskAllocation.Owner = "Swapna";
                    }
                    allocationData.Add(newTaskAllocation);
                }
            }

            foreach (var alloc in allocationData)
            {
                if (alloc.Owner != string.Empty && alloc.Owner != null)
                {
                    //parts.Find(x => x.PartName.Contains("seat")));
                    Developer x = Team.Find(g => g.Name.Contains(alloc.Owner));
                    if (x != null)
                    {
                        x.UsedCapacity += alloc.ToDo;
                    }
                }
                
                
            }

            return allocationData;
        }
    }
}
