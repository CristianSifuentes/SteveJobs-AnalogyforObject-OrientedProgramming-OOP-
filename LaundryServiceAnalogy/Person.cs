public class Person
{
    private readonly ILaundryService _laundryService;
    public string Name { get; }

    public Person(string name, ILaundryService laundryService){
        Name = name;
        _laundryService = laundryService;
    }

    public void DoLaundry(string clothes){
         Console.WriteLine($"{Name} 🏠: \"I need my {clothes} washed!\"");
         string cleanClothes = _laundryService.WashClothes(clothes);
         Console.WriteLine($"{Name} ✅: \"Thanks! I got my {cleanClothes}!\"");

    }
}