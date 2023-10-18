using System.Net;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "Прохоренко Олександр";

        Address address = new Address();
        address.Index = "04053";
        address.Country = "Ukraine";
        address.City = "Kyiv";
        address.Street = "Levka Lukyanenko";
        address.House = "13B";
        address.Apartment = "521";
        Console.WriteLine("Поштова адреса");
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");


    }
}
