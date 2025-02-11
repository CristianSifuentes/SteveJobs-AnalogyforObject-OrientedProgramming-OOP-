public class LaundryService : ILaundryService
{
    public string WashClothes(string clothes)
    {
        // Simulate a delay (e.g., laundry processing)
        Console.WriteLine($"🧺 Taking {clothes} to the best laundromat...");

        System.Threading.Thread.Sleep(2000);


        Console.WriteLine("💦 Washing clothes...");

        System.Threading.Thread.Sleep(2000);


        Console.WriteLine("🚕 Returning with clean clothes.");
        return $"Cleaned {clothes}";

    }
}

