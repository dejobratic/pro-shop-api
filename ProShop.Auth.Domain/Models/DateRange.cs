using System;

namespace ProShop.Auth.Domain.Models
{
    public class DateRange
    {
        public DateTime From { get; }
        public DateTime To { get; }

        public DateRange(
            DateTime from, 
            DateTime to)
        {
            From = from;
            To = to;

            // TODO: add validation logic
        }
    }
}
