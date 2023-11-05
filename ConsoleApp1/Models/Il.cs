using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Il
    {
        public Il()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public int Il1 { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
