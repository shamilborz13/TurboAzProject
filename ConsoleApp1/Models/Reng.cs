using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Reng
    {
        public Reng()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Reng1 { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
