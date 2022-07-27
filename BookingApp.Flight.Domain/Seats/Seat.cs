using BookingApp.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Flight.Domain.Seats
{
    public class Seat : Aggregate<long>
    {
        public string SeatNumber { get; private set; }
        public SeatType Type { get; private set; }
        public SeatClass Class { get; private set; }
        public long FlightId { get; private set; }
    }
}
