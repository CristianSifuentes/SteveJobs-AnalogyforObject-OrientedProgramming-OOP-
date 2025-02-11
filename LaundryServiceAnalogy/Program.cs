class Program
{
    static void Main()
    {
        ILaundryService laundryService = new LaundryService();
        Person person = new Person("Alice", laundryService);

        person.DoLaundry("T-shirts and jeans");
    }
}