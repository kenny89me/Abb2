using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbbTest2.Models
{
    [Serializable]
    public class Measure : IEnumerable
    {
        [Key]
        public int MeasureId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm\:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "TimeStamp")]
        public TimeSpan Timestamp { get; set; }

        public int MotorId { get; set; }

        public string MotorName { get; set; }
        public decimal? CurrentA { get; set; }
        public decimal? MaxTorque { get; set; }
        public decimal? MaxPressure { get; set; }
        public decimal? ActualCurrentA { get; set; }
        public decimal? ActualRevsRpm { get; set; }
        public decimal? ActualPressureBar { get; set; }
        public decimal? Difference { get; set; }

        public virtual Motor Motor { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}