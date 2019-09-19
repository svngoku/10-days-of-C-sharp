using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkItem [] items = {
                new WorkItem(),
                new WorkItem("Managing dataset", "Try to find some tricks on my Code", new TimeSpan(3,4,0,0))
            };
            ChangeRequest change = new ChangeRequest("Update CMDB", 
                "Remove data in Insigth Database", new TimeSpan(4,0,0),1);
            
            Console.WriteLine($"Change: {change.ToString()}");

            change.Update("Rename CMDB in pap.fr", new TimeSpan(1,12,0,0));

            Console.WriteLine($"new Change: {change.ToString()}");
            

            foreach (var item in items)
            {
                Console.WriteLine("**************");
                Console.WriteLine(item.ToString());
            }
            
            Console.ReadLine();
            
        }
    }
}
