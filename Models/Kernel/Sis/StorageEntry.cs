namespace Ava.Shared.Models.Kernel.Sis
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public class StorageEntry
    {
        [Key]
        [JsonPropertyName("id")]
        [Required]
        public required string Id { get; set; }

        [JsonPropertyName("serializedData")]
        [Required]
        public required string SerializedData { get; set; }

        [JsonPropertyName("expires")]

        public DateTime Expires { get; set; } = DateTime.UtcNow.AddDays(3);
    }
}
