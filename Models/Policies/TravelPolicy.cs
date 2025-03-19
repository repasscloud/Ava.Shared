using Ava.Shared.Models.Kernel.Client;

namespace Ava.Shared.Models.Policies
{
    public class TravelPolicy
    {
        public int Id { get; set; }
        public required string PolicyName { get; set; }

        public int AvaClientId { get; set; }

        // currency
        [CurrencyTypeValidation]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = "Currency must be exactly 3 uppercase letters.")]
        [JsonPropertyName("currency")]
        [DefaultValue("AUD")]
        public string? Currency { get; set; } = "AUD";

        // max flight money able to be spent
        public int MaxFlightPrice { get; set; } = 0;

        // flight default details
        [CabinTypeValidation]
        public string DefaultFlightSeating { get; set; } = "ECONOMY";

        [CabinTypeValidation]
        public string MaxFlightSeating { get; set; } = "ECONOMY";
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? IncludedAirlineCodes { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExcludedAirlineCodes { get; set; }
        public bool NonStopFlight { get; set; } = false;


        [JsonIgnore] // Prevent circular reference during serialization.
        public AvaClient? AvaClient { get; set; }

        // Allowed destinations (can be entire regions, continents, or specific countries)
        public ICollection<Region> Regions { get; set; } = new List<Region>();
        public ICollection<Continent> Continents { get; set; } = new List<Continent>();
        public ICollection<Country> Countries { get; set; } = new List<Country>();

        // If a broader selection is made (e.g. enabling APAC),
        // you can exclude specific countries via this collection.
        public ICollection<TravelPolicyDisabledCountry> DisabledCountries { get; set; } = new List<TravelPolicyDisabledCountry>();
    }
}
