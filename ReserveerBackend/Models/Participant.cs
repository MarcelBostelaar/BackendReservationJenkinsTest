﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveerBackend.Models
{
    public class Participant
    {
        [Required]
        public Reservation Reservation { get; set; }
        [Required]
        public User User { get; set; }

        public int UserID { get; set; }
        public int ReservationID { get; set; }
        [Required]
        public bool IsOwner { get; set; }
    }
}