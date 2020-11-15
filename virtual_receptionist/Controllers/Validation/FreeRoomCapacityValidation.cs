﻿using System;
using System.Collections.Generic;
using virtual_receptionist.Models;
using virtual_receptionist.Repositories;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Szabad szobakapacitás ellenőrző osztály
    /// </summary>
    public class FreeRoomCapacityValidation
    {
        #region Adattagok

        /// <summary>
        /// Szoba egyed
        /// </summary>
        private readonly Room room;

        /// <summary>
        /// Foglalás egyed
        /// </summary>
        private readonly Booking booking;

        /// <summary>
        /// Foglalásokat tartalmazó lista
        /// </summary>
        private readonly List<Booking> bookings;

        /// <summary>
        /// Foglalások adattár egy példánya
        /// </summary>
        private readonly BookingRepository repository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Szabad szobakapacitás ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="room"></param>
        /// <param name="booking"></param>
        public FreeRoomCapacityValidation(Room room, Booking booking)
        {
            this.room = room;
            this.booking = booking;

            repository = new BookingRepository();
            bookings = repository.GetBookings();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Szabad szobakapcitást ellenőrző metódus adott napon
        /// </summary>
        public void ValidateFreeRoomCapacityOnSpecifiedArrivalDate()
        {
            foreach (Booking booking in bookings)
            {
                if (this.booking.ArrivalDate == booking.ArrivalDate && this.booking.Room.Number == booking.Room.Number)
                {
                    throw new Exception();
                }
            }
        }

        #endregion
    }
}