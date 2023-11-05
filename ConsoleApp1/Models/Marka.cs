using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Marka
    {
        public Marka()
        {
            Cars = new HashSet<Car>();
            Models = new HashSet<Model>();
        }

        public int Id { get; set; }
        public string MarkaName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
