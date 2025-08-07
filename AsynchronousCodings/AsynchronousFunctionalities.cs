namespace practices_basics.AsynchronousFunctionalities
{

    public class AsyncCodings
    {
        public async Task DownloadDataAsync()
        {
            try
            {
                Console.WriteLine("Download started 1 ...");
                // throw new InvalidOperationException("Simulated download error.");
                await Task.Delay(3000);
                Console.WriteLine("Download 1 completed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

          public async Task DownloadDataAsync2()
        {
            Console.WriteLine("Download 2 started...");
            await Task.Delay(2000);
            Console.WriteLine("Download 2 completed.");
        }
        
   
    }

   

   
}