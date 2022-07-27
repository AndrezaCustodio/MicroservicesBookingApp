﻿using BookingApp.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Booking.Domain.Interfaces
{
    public interface IBookingRepository : IBookingRepository<Models.Booking>
    {
        Task<Models.Booking> GetById(Guid id);
        void Add(Models.Booking booking);
        void Update(Models.Booking booking);

        DbConnection GetConnection();
    }
    
}
