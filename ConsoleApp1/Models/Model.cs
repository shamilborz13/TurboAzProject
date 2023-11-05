using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Model
    {
        public Model()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string ModelName { get; set; } = null!;
        public int MarkaId { get; set; }

        public virtual Marka Marka { get; set; } = null!;
        public virtual ICollection<Car> Cars { get; set; }
    }
}
