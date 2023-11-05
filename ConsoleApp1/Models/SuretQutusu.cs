﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class SuretQutusu
    {
        public SuretQutusu()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string SuretQutusu1 { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
