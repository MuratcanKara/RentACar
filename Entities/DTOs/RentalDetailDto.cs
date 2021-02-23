﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentalDetailDto :IDto
    {

        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public string Description { get; set; }

    }
}
