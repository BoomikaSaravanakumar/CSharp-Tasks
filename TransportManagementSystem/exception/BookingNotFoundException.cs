﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementSystem.exception
{
    public class BookingNotFoundException : Exception
        {
            public BookingNotFoundException() : base("Booking not found.") { }

            public BookingNotFoundException(string message) : base(message) { }
        }
    }


