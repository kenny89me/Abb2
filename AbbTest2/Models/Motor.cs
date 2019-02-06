using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbbTest2.Models
{
    public enum MotorType
    {
        Electric, Combustion, Hydraulic
    }
    public class Motor
    {
        [Key]
        public int MotorId { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Motor Name")]
        public string MotorName { get; set; }

        public MotorType? MotorType { get; set; }

        [Required]
        [Display(Name = "Max Power (kW)")]
        public decimal MaxPower { get; set; }
        public decimal? VoltageV { get; set; }
        public decimal? CurrentA { get; set; }
        public decimal? FuelCons { get; set; }
        public decimal? MaxTorque { get; set; }
        public decimal? MaxPressure { get; set; }
        public decimal? Displacemnt { get; set; }

        public virtual ICollection<Measure> Measures { get; set; }

    }
}