using System;
using System.ComponentModel.DataAnnotations;

namespace EventTracker.Models
{
    public class EventModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EventName { get; set; }
        public string? EventDescription { get; set; }
        public DateTime EventTime { get; set; }
        public string EventTag { get; set; }
    }
}

