namespace Ava.Shared.Models.Search.Flights;

public class FlightSearchResult
{
    // this was added for debug purposes
    [JsonPropertyName("ErrorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("meta")]
    public Meta? Meta { get; set; }

    [JsonPropertyName("data")]
    public List<FlightOffer>? Data { get; set; }

    [JsonPropertyName("dictionaries")]
    public Dictionaries? Dictionaries { get; set; }
}

public class Meta
{
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("links")]
    public Dictionary<string, string>? Links { get; set; }
}

public class FlightOffer
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("instantTicketingRequired")]
    public bool InstantTicketingRequired { get; set; }

    [JsonPropertyName("nonHomogeneous")]
    public bool nonHomogeneous { get; set; }

    [JsonPropertyName("oneWay")]
    public bool OneWay { get; set; }

    [JsonPropertyName("isUpsellOffer")]
    public bool IsUpsellOffer { get; set; }

    [JsonPropertyName("lastTicketingDate")]
    public string? LastTicketingDate { get; set; }

    [JsonPropertyName("lastTicketingDateTime")]
    public string? LastTicketingDateTime { get; set; }

    [JsonPropertyName("numberOfBookableSeats")]
    public int? NumberOfBookableSeats { get; set; }

    
    // itinerary goes below here
    [JsonPropertyName("itineraries")]
    public List<Itinerary>? Itineraries { get; set; }

    [JsonPropertyName("price")]
    public Price? Price { get; set; }

    [JsonPropertyName("pricingOptions")]
    public PricingOption? PricingOptions { get; set; }

    [JsonPropertyName("validatingAIrlineCodes")]
    public List<string>? ValidatingAirlineCodes { get; set; }

    [JsonPropertyName("travelerPricings")]
    public List<TravelerPricing>? TravelerPricings { get; set; }
}

public class Itinerary
{
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("segments")]
    public List<Segment>? Segments { get; set; }
}

public class Segment
{
    [JsonPropertyName("departure")]
    public SegmentDeparture? Departure { get; set; }

    [JsonPropertyName("arrival")]
    public SegmentArrival? Arrival { get; set; }

    [JsonPropertyName("carrierCode")]
    public string? CarrierCode { get; set; }

    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("aircraft")]
    public SegmentAircraft? Aircraft { get; set; }

    [JsonPropertyName("operating")]
    public SegmentOperating? Operating { get; set; }

    [JsonPropertyName("duration")]
    public string? duration { get; set; }

    [JsonPropertyName("stops")]
    public List<SegmentStop>? Stops { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("numberOfStops")]
    public int? numberOfStops { get; set; }

    [JsonPropertyName("blacklistedInEU")]
    public bool BlacklistedInEU { get; set; }
}

public class SegmentDeparture
{
    [JsonPropertyName("iataCode")]
    public string? IATACode { get; set; }

    [JsonPropertyName("terminal")]
    public string? Terminal { get; set; }

    [JsonPropertyName("at")]
    public string? At { get; set; }
}

public class SegmentArrival
{
    [JsonPropertyName("iataCode")]
    public string? IATACode { get; set; }

    [JsonPropertyName("terminal")]
    public string? Terminal { get; set; }

    [JsonPropertyName("at")]
    public string? At { get; set; }
}

public class SegmentAircraft
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

public class SegmentOperating
{
    [JsonPropertyName("carrierCode")]
    public string? CarrierCode { get; set; }
}

public class SegmentStop
{
    [JsonPropertyName("iataCode")]
    public string? IATACode { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("arrivalAt")]
    public string? ArrivalAt { get; set; }

    [JsonPropertyName("departureAt")]
    public string? DepartureAt { get; set; }
}

public class Price
{
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("total")]
    public string? Total { get; set; }

    [JsonPropertyName("base")]
    public string? Base { get; set; }

    [JsonPropertyName("fees")]
    public List<PriceFee>? Fees { get; set; }

    [JsonPropertyName("grandTotal")]
    public string? GrandTotal { get; set; }
}

public class PriceFee
{
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public class PricingOption
{
    [JsonPropertyName("fareType")]
    public List<string>? FareType { get; set; }

    [JsonPropertyName("includedCheckedBagsOnly")]
    public bool IncludedCheckedBagsOnly { get; set; }
}

public class TravelerPricing
{
    [JsonPropertyName("travelerId")]
    public string? TravelerId { get; set; }

    [JsonPropertyName("fareOption")]
    public string? FareOption { get; set; }

    [JsonPropertyName("travelerType")]
    public string? TravelerType { get; set; }

    [JsonPropertyName("price")]
    public TravelerPricingPrice? Price { get; set; }

    [JsonPropertyName("fareDetailsBySegment")]
    public List<FareDetailBySegment>? FareDetailsBySegment { get; set; }
}

public class TravelerPricingPrice
{
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("total")]
    public string? Total { get; set; }

    [JsonPropertyName("base")]
    public string? Base { get; set; }
}

public class FareDetailBySegment
{
    [JsonPropertyName("segmentId")]
    public string? SegmentId { get; set; }

    [JsonPropertyName("cabin")]
    public string? Cabin { get; set; }

    [JsonPropertyName("fareBasis")]
    public string? FareBasis { get; set; }

    [JsonPropertyName("brandedFare")]
    public string? BrandedFare { get; set; }

    [JsonPropertyName("brandedFareLabel")]
    public string? BrandedFareLabel { get; set; }

    [JsonPropertyName("class")]
    public string? Class { get; set; }

    [JsonPropertyName("includedCheckedBags")]
    public FareDetailBySegmentIncludedCheckedBags? IncludedCheckedBags { get; set; }

    [JsonPropertyName("amenities")]
    public List<FareDetailBySegmentAmenity>? Amenities { get; set; }
}

public class FareDetailBySegmentIncludedCheckedBags
{
    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }

    [JsonPropertyName("weightUnit")]
    public string? WeightUnit { get; set; }
}

public class FareDetailBySegmentAmenity
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("isChargeable")]
    public bool IsChargeable { get; set; }

    [JsonPropertyName("amenityType")]
    public string? AmenityType { get; set; }

    [JsonPropertyName("amenityProvider")]
    public FareDetailBySegmentAmenityAmenityProvider? AmenityProvider { get; set; }
}

public class FareDetailBySegmentAmenityAmenityProvider
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public class Dictionaries
{
    [JsonPropertyName("locations")]
    public Dictionary<string, DictionariesLocation>? Locations { get; set; }

    [JsonPropertyName("aircraft")]
    public Dictionary<string, string>? Aircraft { get; set; }

    [JsonPropertyName("currencies")]
    public Dictionary<string, string>? Currencies { get; set; }

    [JsonPropertyName("carriers")]
    public Dictionary<string, string>? Carriers { get; set; }
}

public class DictionariesLocation
{
    [JsonPropertyName("cityCode")]
    public string? CityCode { get; set; }

    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }
}
