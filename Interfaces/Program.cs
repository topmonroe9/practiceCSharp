using System.Collections;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlowEngine();
            workFlow.RegisterActivity(new Chess());
            workFlow.RegisterActivity(new Swimming());
            workFlow.Run();
        }
    }
}
