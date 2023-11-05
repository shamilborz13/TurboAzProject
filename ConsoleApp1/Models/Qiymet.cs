using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Qiymet
    {
        public Qiymet()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public int Qiymet1 { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
