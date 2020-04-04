using System;

namespace AnkiCard.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public string Category { get; set; }
        public double ForgettingRate { get; set; }
        public DateTimeOffset InsertDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
