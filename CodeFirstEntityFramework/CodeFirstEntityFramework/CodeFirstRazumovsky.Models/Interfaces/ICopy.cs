﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstEntityFramework
{
    public interface ICopy
    {
        public int CopyId { get; set; }
        public bool Available { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
