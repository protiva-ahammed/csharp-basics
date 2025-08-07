namespace practices_basics.AsynchronousFunctionalities
{
    // public async Task SimulateDelay()
    // {
    //     // time consuming tasks ex: data retriving from db, wating for response
    //     await Task.Delay(5000);
    //     Console.WriteLine("Operation completed after 5 s .");
    // }

    // public async Task ReadfilesAsync(string filePath)
    // {
    //     using (StreamReader reader = new StreamReader(filePath));
    //     {
    //         string content = await reader.ReadToEndAsync();

    //         Console.WriteLine(content);
    //     }
    // }
    public class AsyncCodings{
         public async Task DowloadDataAsync()
        {

            Console.WriteLine("Download started..");
            await Task.Delay(5000);
            Console.WriteLine("Download completed! ");
        }
    }

   

   
}