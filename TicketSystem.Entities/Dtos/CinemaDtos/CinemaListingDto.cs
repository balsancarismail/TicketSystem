﻿using TicketSystem.Core.Abstract.Entities;

namespace TicketSystem.Entities.Dtos
{
    public class CinemaListingDto : IDto
    {
        public int CinemaId { get; set; }
        public string? CinemaName { get; set; }
        public string? CinemaAddress { get; set; }
    }
}