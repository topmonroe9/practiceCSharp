using System.Collections.Generic;

namespace Interfaces
{
    public class WorkFlowEngine
    {
        private readonly IList<IActivities> _activities;
        public WorkFlowEngine()
        {
            _activities = new List<IActivities>();
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Start();
                activity.Finish();
            }
        }

        public void RegisterActivity(IActivities activity)
        {
            _activities.Add(activity);
        }
    }
}