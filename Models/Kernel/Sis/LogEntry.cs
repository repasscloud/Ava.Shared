namespace Ava.Shared.Models.Kernel.Sis
{
    using System.ComponentModel.DataAnnotations;
    public class LogEntry
    {
        [Key]
        public int Id { get; set; }
        public string Level { get; set; } = string.Empty;  // TRACE, DEBUG, INFO, etc.
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
