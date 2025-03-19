namespace Ava.Shared.Models.Static;

public static class FareTypes
{
    public static Dictionary<string, string> AirfaresBookingClassOptions { get; set; } = new Dictionary<string, string>()
    {
        { "Economy 💰", "ECONOMY" },
        { "Premium Economy 💰💰", "PREMIUM_ECONOMY" },
        { "Business 💰💰💰", "BUSINESS" },
        { "First 💰💰💰💰", "FIRST"}
    };
}
