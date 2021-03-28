using System;

namespace Interfaces
{
    public class Chess : IActivities
    {
        public void Start()
        {
            Console.WriteLine("Playing chess");

        }

        public void Finish()
        {
            Console.WriteLine("Finish Playing chess");

        }
    }
}