using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public int MarkaId { get; set; }
        public int ModelId { get; set; }
        public int SheherId { get; set; }
        public int QiymetId { get; set; }
        public int IlId { get; set; }
        public int RengId { get; set; }
        public int MotorId { get; set; }
        public int SuretId { get; set; }
        public int YanavagId { get; set; }
        public int ShekeilId { get; set; }

        public virtual Il Il { get; set; } = null!;
        public virtual Marka Marka { get; set; } = null!;
        public virtual Model Model { get; set; } = null!;
        public virtual Motor Motor { get; set; } = null!;
        public virtual Qiymet Qiymet { get; set; } = null!;
        public virtual Reng Reng { get; set; } = null!;
        public virtual Sheher Sheher { get; set; } = null!;
        public virtual Shekil Shekeil { get; set; } = null!;
        public virtual SuretQutusu Suret { get; set; } = null!;
        public virtual Yanacag Yanavag { get; set; } = null!;
    }
}
