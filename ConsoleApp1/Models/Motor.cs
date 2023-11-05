using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Motor
    {
        public Motor()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public int Motor1 { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
