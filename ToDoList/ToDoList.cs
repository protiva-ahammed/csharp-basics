using System.Security.Cryptography.X509Certificates;
namespace practices_basics.ToDoList
{
    public class ToDoLists
{
    public static string[] tasks = new string[11];
    public static int taskCount = 1;


    public static void ViewTasks()
        {
            if (string.IsNullOrEmpty(tasks[1]))
            {
                Console.WriteLine("No Task in Scheduled ");return;
            }
            Console.WriteLine("Today's upcoming tasks : ");
            for (int i = 1; i < taskCount; i++)
            {
                Console.WriteLine(" "+ i + ". " + tasks[i]);

            }
        }

    public static void AddTask()
    {
        Console.WriteLine("Enter a new tasks : ");
        tasks[taskCount] = Console.ReadLine();
        taskCount++;
    }

    public static void CompleteTask()
    {
        Console.WriteLine("Enter the task number to complete : ");
        int taskNumber = int.Parse(Console.ReadLine());
        if (taskNumber >= 1 && taskNumber <= taskCount)
        {
            tasks[taskNumber] = tasks[taskNumber] + "--> Completed ";
        }
        else
        {
            Console.WriteLine("Invalid task Number " + taskNumber);
        }

        
    }
   
}
}
