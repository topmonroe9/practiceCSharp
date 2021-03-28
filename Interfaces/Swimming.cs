using System;

namespace Interfaces
{
    public class Swimming : IActivities
    {
        public void Start()
        {
            Console.WriteLine("going to the swimming pool");
        }

        public void Finish()
        {
            Console.WriteLine("returning from the swimming pool");
        }
    }
}